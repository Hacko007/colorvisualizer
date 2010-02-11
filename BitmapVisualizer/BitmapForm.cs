using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace BitmapVisualizer
{
    public partial class BitmapForm : Form
    {
        public BitmapForm()
        {
            InitializeComponent();
        }
        private Bitmap aBitmap = null;
        public Bitmap Bitmap
        {
            get { return aBitmap; }
            set { aBitmap = value;
            this.pictureBox.Image = value;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

  
}
