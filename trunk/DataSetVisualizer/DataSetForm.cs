using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Hackovic.VisualStudio
{
  public partial class DataSetForm : Form
  {
    public DataSetForm()
    {
      InitializeComponent();
    }

    public DataSet DataSet
    {
      get;
      set;
    }

    public DataTable DataTable
    {
      get
      {
        if( DataSet == null || DataSet.Tables.Count == 0 )
        {
          return null;
        }
        return DataSet.Tables[m_ComboBox.SelectedIndex];
      }
    }

    private void ComboBoxSelectedIndexChanged( object sender, System.EventArgs e )
    {
      try
      {
        m_DataGridView.DataSource = DataSet;
        m_DataGridView.DataMember = DataSet.Tables[m_ComboBox.SelectedIndex].TableName;
      }
      catch
      {
      }
    }

    private void ButtonExportTableClick( object sender, System.EventArgs e )
    {
      if( DataTable == null )
        return;

      if (m_SaveFileDialog.ShowDialog(this) != DialogResult.OK) return;
      try
      {
        Stream myStream = m_SaveFileDialog.OpenFile();
        DataTable.WriteXml( myStream, XmlWriteMode.WriteSchema );
        myStream.Close();     

      }
      catch
      {
        MessageBox.Show("Failed to write to file");
      }

    }

    private void ButtonExportDatasetClick( object sender, System.EventArgs e )
    {
      if( DataSet == null )
        return;

      if (m_SaveFileDialog.ShowDialog(this) != DialogResult.OK) return;
      
      try
      {
        Stream myStream = m_SaveFileDialog.OpenFile();
   
        DataSet.WriteXml( myStream, XmlWriteMode.WriteSchema );
        myStream.Close();
       }
      catch
      {
        MessageBox.Show("Failed to write to file");
      }
    }

    internal void InitForm()
    {
      m_ComboBox.Items.Clear();

      if( DataSet == null || DataSet.Tables.Count == 0 )
        return;

      foreach( DataTable table in DataSet.Tables )
      {
        m_ComboBox.Items.Add( table.TableName );
      }
      m_ComboBox.SelectedIndex = 0;
      Text = DataSet.DataSetName;
    }

    private void ButtonCloseClick( object sender, System.EventArgs e )
    {
      Close();
    }
  }
}
