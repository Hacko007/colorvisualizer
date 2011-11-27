using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hackovic.VisualStudio
{
  public partial class DataSetForm : Form
  {
    public DataSetForm()
    {
      InitializeComponent();
    }

    #region Properties

    public FilterCondition FilterCondition { get; set; }
    public DataSet DataSet { get; set; }

    /// <summary>
    ///   Gets or set selected <see cref = "System.Data.DataTable" />
    /// </summary>
    public DataTable DataTable
    {
      get
      {
        if (DataSet == null || DataSet.Tables.Count == 0)
        {
          return null;
        }
        return DataSet.Tables[m_ComboBox.SelectedIndex];
      }
    }

    /// <summary>
    ///   Gets or sets indication if ComboBox with table names is disabled
    /// </summary>
    public bool DisableTableListBox
    {
      get { return m_disableTableListBox; }
      set
      {
        m_disableTableListBox = value;
        m_ComboBox.Enabled = !m_disableTableListBox;
      }
    }

    #endregion

    internal void InitForm()
    {
      m_ComboBox.Items.Clear();

      if (DataSet == null || DataSet.Tables.Count == 0)
      {
        return;
      }

      foreach (DataTable table in DataSet.Tables)
      {
        m_ComboBox.Items.Add(table.TableName);
      }
      m_ComboBox.SelectedIndex = 0;
      Text = DataSet.DataSetName;
    }

    private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        if (FilterCondition == null || string.IsNullOrEmpty(FilterCondition.ToString()))
        {
          m_DataGridView.DataSource = DataSet;
          m_DataGridView.DataMember = DataSet.Tables[m_ComboBox.SelectedIndex].TableName;
          m_labelInfo.Text = string.Format("{0} rows in table.", DataSet.Tables[m_ComboBox.SelectedIndex].Rows.Count);
          m_buttonRemoveRelation.Visible = false;
        }
        else
        {
          DataView dv = new DataView(DataSet.Tables[FilterCondition.TargetTable.TableName], FilterCondition.ToString(),
                                     null, DataViewRowState.CurrentRows);
          m_DataGridView.DataSource = dv;
          m_labelInfo.Text = FilterCondition.IsFilterOnValue
                               ? string.Format("Filtered: {0} rows. Filter:{1}", dv.Count, FilterCondition)
                               : string.Format("Ralated: {0} rows.  Filter:{1}", dv.Count, FilterCondition);
          FilterCondition = null;
        }
      }
      catch
      {
      }
    }


    private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    /// <summary>
    ///   Build context menu on cell click
    /// </summary>
    /// <param name = "sender"></param>
    /// <param name = "e"></param>
    private void DataGridView_CellContextMenuStripNeeded(object sender,
                                                         DataGridViewCellContextMenuStripNeededEventArgs e)
    {
      e.ContextMenuStrip = null;
      filterOnCellValueToolStripMenuItem.Tag = null;
      parentRowToolStripMenuItem.DropDownItems.Clear();
      childRowsToolStripMenuItem.DropDownItems.Clear();
      if (e.ColumnIndex < 0 || e.RowIndex < 0 || DataSet == null || DataTable == null)
      {
        return;
      }

      e.ContextMenuStrip = m_cellContextMenuStrip;
      // Initailize filter on cell content
      filterOnCellValueToolStripMenuItem.Tag = new FilterCondition
                                                 {
                                                   TargetTable = DataTable,
                                                   FilterOnColumns = new[] {DataTable.Columns[e.ColumnIndex]},
                                                   SourceColumns = new[] {DataTable.Columns[e.ColumnIndex]},
                                                   SourceRow = DataTable.Rows[e.RowIndex],
                                                   IsFilterOnValue = true
                                                 };

      // Initailize filter on parent relations
      foreach (DataRelation parentRelation in DataTable.ParentRelations)
      {
        foreach (DataColumn childColumn in
          parentRelation.ChildColumns.Where(
            childColumn => childColumn.ColumnName == DataTable.Columns[e.ColumnIndex].ColumnName))
        {
          ToolStripMenuItem toolMenuItem =
            new ToolStripMenuItem(parentRelation.ParentTable + " => " + parentRelation.RelationName, null,
                                  OnMenuItemClick,
                                  parentRelation.RelationName)
              {
                Tag = new FilterCondition
                        {
                          TargetTable = parentRelation.ParentTable,
                          FilterOnColumns = parentRelation.ParentColumns,
                          SourceColumns = parentRelation.ChildColumns,
                          SourceRow = DataTable.Rows[e.RowIndex]
                        }
              };
          parentRowToolStripMenuItem.DropDownItems.Add(toolMenuItem);
        }
      }

      // Initailize filter on child relations
      foreach (DataRelation childRelation in from DataRelation childRelation in DataTable.ChildRelations
                                             from parentColumn in childRelation.ParentColumns
                                             where
                                               parentColumn.ColumnName == DataTable.Columns[e.ColumnIndex].ColumnName
                                             select childRelation)
      {
        ToolStripMenuItem toolMenuItem =
          new ToolStripMenuItem(childRelation.ChildTable + " =>" + childRelation.RelationName, null, OnMenuItemClick,
                                childRelation.RelationName)
            {
              Tag = new FilterCondition
                      {
                        TargetTable = childRelation.ChildTable,
                        FilterOnColumns = childRelation.ChildColumns,
                        SourceColumns = childRelation.ParentColumns,
                        SourceRow = DataTable.Rows[e.RowIndex]
                      }
            };
        childRowsToolStripMenuItem.DropDownItems.Add(toolMenuItem);
      }

      parentRowToolStripMenuItem.Visible = parentRowToolStripMenuItem.DropDownItems.Count > 0;
      childRowsToolStripMenuItem.Visible = childRowsToolStripMenuItem.DropDownItems.Count > 0;
    }

    private void OnMenuItemClick(object sender, EventArgs e)
    {
      ToolStripMenuItem item = sender as ToolStripMenuItem;
      if (item == null || item.Tag == null)
      {
        return;
      }
      FilterCondition filterCondition = item.Tag as FilterCondition;

      if (filterCondition == null)
      {
        return;
      }

      FilterTableOnRelation(filterCondition);
    }

    /// <summary>
    ///   Apply <paramref name = "filterCondition" /> filter on data.
    /// </summary>
    /// <param name = "filterCondition"></param>
    private void FilterTableOnRelation(FilterCondition filterCondition)
    {
      FilterCondition = filterCondition;
      m_buttonRemoveRelation.Visible = true;
      if (filterCondition.TargetTable.TableName == DataTable.TableName)
      {
        ComboBoxSelectedIndexChanged(this, EventArgs.Empty);
        return;
      }

      foreach (string table in m_ComboBox.Items)
      {
        if (table == filterCondition.TargetTable.TableName)
        {
          m_ComboBox.SelectedItem = table;
        }
      }
    }

    #region Button click events

    private void ButtonExportTableClick(object sender, EventArgs e)
    {
      if (DataTable == null)
      {
        return;
      }

      m_SaveFileDialog.FileName = DataTable.TableName;
      if (m_SaveFileDialog.ShowDialog(this) != DialogResult.OK)
      {
        return;
      }
      try
      {
        Stream myStream = m_SaveFileDialog.OpenFile();
        DataTable.WriteXml(myStream, XmlWriteMode.WriteSchema);
        myStream.Close();
      }
      catch
      {
        MessageBox.Show(@"Failed to write to file");
      }
    }

    private void ButtonExportDatasetClick(object sender, EventArgs e)
    {
      if (DataSet == null)
      {
        return;
      }
      m_SaveFileDialog.FileName = DataSet.DataSetName;
      if (m_SaveFileDialog.ShowDialog(this) != DialogResult.OK)
      {
        return;
      }

      try
      {
        Stream myStream = m_SaveFileDialog.OpenFile();

        DataSet.WriteXml(myStream, XmlWriteMode.WriteSchema);
        myStream.Close();
      }
      catch
      {
        MessageBox.Show(@"Failed to write to file");
      }
    }

    private void ButtonRemoveRelation_Click(object sender, EventArgs e)
    {
      FilterCondition = null;
      ComboBoxSelectedIndexChanged(this, EventArgs.Empty);
      m_buttonRemoveRelation.Visible = false;
    }

    private void ButtonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    #endregion
  }
}