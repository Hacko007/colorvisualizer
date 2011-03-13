using System;
using System.Windows.Forms;

namespace NumberVisualizer
{
  public partial class NumberForm : Form
  {
    public NumberForm()
    {
      InitializeComponent();
    }

    public int Int
    {
      get { return 0; }
      set {
        Bin = Convert.ToString( value, 2 );
        Hex = "0x" + Convert.ToString( value, 16 ).ToUpper();
        Dec = Convert.ToString( value, 10 );
      }
    }

    public string Hex
    {
      get
      {
        return m_TextBoxHex.Text;
      }
      set { m_TextBoxHex.Text = value; }
    }

    public string Dec
    {
      get
      {
        return m_TextBoxDec.Text;
      }
      set { m_TextBoxDec.Text = value; }
    }

    public string Bin
    {
      get
      {
        return m_TextBoxBin.Text;
      }
      set { m_TextBoxBin.Text = value; }
    }

    private void ButtonCloseClick( object sender, EventArgs e )
    {
      Close();
    }

    private void ButtonCopyDecClick( object sender, EventArgs e )
    {
      Clipboard.SetText( Dec );
    }

    private void ButtonCopyHexClick( object sender, EventArgs e )
    {
      Clipboard.SetText( Hex );
    }

    private void ButtonCopyBinClick( object sender, EventArgs e )
    {
      Clipboard.SetText( Bin );
    }
  }
}
