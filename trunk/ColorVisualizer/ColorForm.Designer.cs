namespace ColorVisualizer
{
	partial class ColorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.groupBoxColorInfo = new System.Windows.Forms.GroupBox();
			this.labelNamedColor = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelRGB = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.panelMain.SuspendLayout();
			this.groupBoxColorInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.BackColor = System.Drawing.Color.White;
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Location = new System.Drawing.Point(239, 50);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(123, 23);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.groupBoxColorInfo);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(368, 187);
			this.panelMain.TabIndex = 1;
			// 
			// groupBoxColorInfo
			// 
			this.groupBoxColorInfo.BackColor = System.Drawing.Color.White;
			this.groupBoxColorInfo.Controls.Add(this.buttonClose);
			this.groupBoxColorInfo.Controls.Add(this.labelName);
			this.groupBoxColorInfo.Controls.Add(this.label2);
			this.groupBoxColorInfo.Controls.Add(this.labelNamedColor);
			this.groupBoxColorInfo.Controls.Add(this.label3);
			this.groupBoxColorInfo.Controls.Add(this.labelRGB);
			this.groupBoxColorInfo.Controls.Add(this.label1);
			this.groupBoxColorInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxColorInfo.Location = new System.Drawing.Point(0, 0);
			this.groupBoxColorInfo.Name = "groupBoxColorInfo";
			this.groupBoxColorInfo.Size = new System.Drawing.Size(368, 86);
			this.groupBoxColorInfo.TabIndex = 0;
			this.groupBoxColorInfo.TabStop = false;
			// 
			// labelNamedColor
			// 
			this.labelNamedColor.AutoSize = true;
			this.labelNamedColor.Font = new System.Drawing.Font("Courier New", 8.25F);
			this.labelNamedColor.Location = new System.Drawing.Point(81, 40);
			this.labelNamedColor.Name = "labelNamedColor";
			this.labelNamedColor.Size = new System.Drawing.Size(42, 14);
			this.labelNamedColor.TabIndex = 3;
			this.labelNamedColor.Text = "Black";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Known color:";
			// 
			// labelRGB
			// 
			this.labelRGB.AutoSize = true;
			this.labelRGB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRGB.Location = new System.Drawing.Point(81, 20);
			this.labelRGB.Name = "labelRGB";
			this.labelRGB.Size = new System.Drawing.Size(84, 14);
			this.labelRGB.TabIndex = 1;
			this.labelRGB.Text = "156,165,156";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "RGB:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Color name:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Courier New", 8.25F);
			this.labelName.Location = new System.Drawing.Point(81, 60);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(42, 14);
			this.labelName.TabIndex = 5;
			this.labelName.Text = "Black";
			// 
			// ColorForm
			// 
			this.AcceptButton = this.buttonClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 187);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ColorForm";
			this.Text = "Color info";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorForm_KeyDown);
			this.panelMain.ResumeLayout(false);
			this.groupBoxColorInfo.ResumeLayout(false);
			this.groupBoxColorInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.GroupBox groupBoxColorInfo;
		private System.Windows.Forms.Label labelNamedColor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelRGB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label label2;
	}
}