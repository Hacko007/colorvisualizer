using System.Drawing;
using System.Windows.Forms;

namespace Hackovic.VisualStudio
{
  public partial class DataRowForm : Form
  {
    public DataRowForm()
    {
      InitializeComponent();
    }

    public DataRowData DataRow
    {
      get;
      set;
    }

    public void InitForm()
    {
      if( DataRow == null )
      {
        return;
      }
      m_TableLayoutPanel.RowCount = DataRow.Columns.Length + 2;

      m_TableLayoutPanel.Controls.Add( new Label
      {
        Text = @"  Row state:",
        TextAlign = ContentAlignment.MiddleLeft,
        Dock = DockStyle.Fill

      }, 0, 0 );
      m_TableLayoutPanel.Controls.Add( new Label
      {
        Text = DataRow.RowState.ToString(),
        Font = new Font( Font, FontStyle.Bold ),
        TextAlign = ContentAlignment.MiddleLeft,
        Dock = DockStyle.Fill
      }, 1, 0 );

      m_TableLayoutPanel.Controls.Add( new Label
                                           {
                                             Text = @"  Column",
                                             BackColor = Color.DarkGray,
                                             ForeColor = Color.White,
                                             TextAlign = ContentAlignment.MiddleLeft,
                                             Dock = DockStyle.Fill

                                           }, 0, 1 );
      m_TableLayoutPanel.Controls.Add( new Label
                                           {
                                             Text = @"  Value",
                                             Font = new Font( Font, FontStyle.Bold ),
                                             BackColor = Color.DarkGray,
                                             ForeColor = Color.White,
                                             TextAlign = ContentAlignment.MiddleLeft,
                                             Dock = DockStyle.Fill
                                           }, 1, 1 );
      int i = 2;
      foreach( string column in DataRow.Columns )
      {
        try
        {

          m_TableLayoutPanel.Controls.Add( new TextBox
                                            {
                                              Text = column,
                                              ReadOnly = true,
                                              Dock = DockStyle.Fill

                                            }, 0, i );

          m_TableLayoutPanel.Controls.Add( new TextBox
                                            {
                                              Text = DataRow.ItemArray[i - 2].ToString(),
                                              ReadOnly = true,
                                              Dock = DockStyle.Fill
                                            }, 1, i );
        }
        catch
        {
        }

        i++;
      }
    }
  }
}