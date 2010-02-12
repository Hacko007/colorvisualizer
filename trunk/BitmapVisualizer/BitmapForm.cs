using System;
using System.Drawing;
using System.Windows.Forms;


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
            set
            {
                aBitmap = value;
                this.pictureBox.Image = value;
                SetTitle();
                ResizeFormToFitImage();
            }
        }

        private void SetTitle()
        { 
            if (this.pictureBox.Image == null)
                return;

            Text += string.Format(" - {0} x {1} pixel", this.pictureBox.Image.Size.Width, this.pictureBox.Image.Size.Height);
        }

        private void ResizeFormToFitImage()
        {
            if (this.pictureBox.Image == null)
                return;

            int width = this.pictureBox.Image.Size.Width + (this.Width - this.ClientRectangle.Width);
            int height = this.pictureBox.Image.Size.Height + (this.Height  - this.ClientRectangle.Height) + this.panelBottom .Height ;
            
            // Smaller then current screen
            width = Math.Min(width, Screen.FromControl(this).WorkingArea.Width - 100);
            height  = Math.Min(height , Screen.FromControl(this).WorkingArea.Height- 100);
            this.Size = new Size(width, height);
            CenterToScreen();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

  
}
