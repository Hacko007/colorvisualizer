using System;
using System.Data;
using System.Windows.Forms;

namespace Hackovic.VisualStudio
{
  public partial class DataGridViewRowForm : Form
  {
    public DataGridViewRowForm()
    {
      InitializeComponent();
    }

    public DataGridViewRow DataGridViewRow { get; set; }
    public RowData RowData { get; set; }    

    public void InitForm()
    {
      if (RowData == null)
        return;

      m_PropertyGrid.SelectedObject = RowData;

      m_DataGridViewCells.DataSource = RowData.Cells;
    }

    private void DataGridViewCellsDataError( object sender, DataGridViewDataErrorEventArgs e )
    {

    }
  }
}