using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hackovic.VisualStudio
{
	public partial class ColorForm : Form
	{
		public ColorForm()
		{
			InitializeComponent();			
			panelMain.BackColor = SystemColors.Control;
			labelRGB.Text = "";
			labelNamedColor.Text = "";
		}

		private Color color;
		public Color Color {
			get { return color; }
			set 
			{ 				
				color = value;
				labelRGB.Text = string.Format("A={0},  R={1}, G={2}, B={3}", color.A, color.R, color.G , color.B);
				labelNamedColor.Text = color.ToKnownColor().ToString();
				labelName.Text = color.Name;
				panelMain.BackColor = color;
				buttonClose.ForeColor = color;
				buttonClose.BackColor = SystemColors.Control;				
			} 
		}

		private void ColorForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape 
				|| e.KeyData == Keys.Return 
				|| e.KeyData == Keys.Enter) {
				this.Close();
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
