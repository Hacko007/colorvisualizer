namespace NumberVisualizer
{
  partial class NumberForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.m_TextBoxDec = new System.Windows.Forms.TextBox();
      this.m_ButtonCopyDec = new System.Windows.Forms.Button();
      this.m_ToolTip = new System.Windows.Forms.ToolTip( this.components );
      this.m_ButtonCopyHex = new System.Windows.Forms.Button();
      this.m_ButtonCopyBin = new System.Windows.Forms.Button();
      this.m_TextBoxHex = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.m_TextBoxBin = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.m_ButtonClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point( 11, 15 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 27, 13 );
      this.label1.TabIndex = 0;
      this.label1.Text = "Dec";
      // 
      // m_TextBoxDec
      // 
      this.m_TextBoxDec.Location = new System.Drawing.Point( 44, 12 );
      this.m_TextBoxDec.Name = "m_TextBoxDec";
      this.m_TextBoxDec.ReadOnly = true;
      this.m_TextBoxDec.Size = new System.Drawing.Size( 213, 20 );
      this.m_TextBoxDec.TabIndex = 1;
      // 
      // m_ButtonCopyDec
      // 
      this.m_ButtonCopyDec.FlatAppearance.BorderSize = 0;
      this.m_ButtonCopyDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.m_ButtonCopyDec.Font = new System.Drawing.Font( "Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 2 ) ) );
      this.m_ButtonCopyDec.Location = new System.Drawing.Point( 260, 10 );
      this.m_ButtonCopyDec.Margin = new System.Windows.Forms.Padding( 0 );
      this.m_ButtonCopyDec.Name = "m_ButtonCopyDec";
      this.m_ButtonCopyDec.Size = new System.Drawing.Size( 26, 23 );
      this.m_ButtonCopyDec.TabIndex = 2;
      this.m_ButtonCopyDec.Text = "";
      this.m_ToolTip.SetToolTip( this.m_ButtonCopyDec, "Copy value" );
      this.m_ButtonCopyDec.UseVisualStyleBackColor = true;
      this.m_ButtonCopyDec.Click += new System.EventHandler( this.ButtonCopyDecClick );
      // 
      // m_ButtonCopyHex
      // 
      this.m_ButtonCopyHex.FlatAppearance.BorderSize = 0;
      this.m_ButtonCopyHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.m_ButtonCopyHex.Font = new System.Drawing.Font( "Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 2 ) ) );
      this.m_ButtonCopyHex.Location = new System.Drawing.Point( 260, 36 );
      this.m_ButtonCopyHex.Margin = new System.Windows.Forms.Padding( 0 );
      this.m_ButtonCopyHex.Name = "m_ButtonCopyHex";
      this.m_ButtonCopyHex.Size = new System.Drawing.Size( 26, 23 );
      this.m_ButtonCopyHex.TabIndex = 5;
      this.m_ButtonCopyHex.Text = "";
      this.m_ToolTip.SetToolTip( this.m_ButtonCopyHex, "Copy value" );
      this.m_ButtonCopyHex.UseVisualStyleBackColor = true;
      this.m_ButtonCopyHex.Click += new System.EventHandler( this.ButtonCopyHexClick );
      // 
      // m_ButtonCopyBin
      // 
      this.m_ButtonCopyBin.FlatAppearance.BorderSize = 0;
      this.m_ButtonCopyBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.m_ButtonCopyBin.Font = new System.Drawing.Font( "Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 2 ) ) );
      this.m_ButtonCopyBin.Location = new System.Drawing.Point( 260, 64 );
      this.m_ButtonCopyBin.Margin = new System.Windows.Forms.Padding( 0 );
      this.m_ButtonCopyBin.Name = "m_ButtonCopyBin";
      this.m_ButtonCopyBin.Size = new System.Drawing.Size( 26, 23 );
      this.m_ButtonCopyBin.TabIndex = 8;
      this.m_ButtonCopyBin.Text = "";
      this.m_ToolTip.SetToolTip( this.m_ButtonCopyBin, "Copy value" );
      this.m_ButtonCopyBin.UseVisualStyleBackColor = true;
      this.m_ButtonCopyBin.Click += new System.EventHandler( this.ButtonCopyBinClick );
      // 
      // m_TextBoxHex
      // 
      this.m_TextBoxHex.Location = new System.Drawing.Point( 44, 38 );
      this.m_TextBoxHex.Name = "m_TextBoxHex";
      this.m_TextBoxHex.ReadOnly = true;
      this.m_TextBoxHex.Size = new System.Drawing.Size( 213, 20 );
      this.m_TextBoxHex.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point( 11, 40 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 26, 13 );
      this.label2.TabIndex = 3;
      this.label2.Text = "Hex";
      // 
      // m_TextBoxBin
      // 
      this.m_TextBoxBin.Location = new System.Drawing.Point( 44, 66 );
      this.m_TextBoxBin.Name = "m_TextBoxBin";
      this.m_TextBoxBin.ReadOnly = true;
      this.m_TextBoxBin.Size = new System.Drawing.Size( 213, 20 );
      this.m_TextBoxBin.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point( 12, 68 );
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size( 22, 13 );
      this.label3.TabIndex = 6;
      this.label3.Text = "Bin";
      // 
      // m_ButtonClose
      // 
      this.m_ButtonClose.Location = new System.Drawing.Point( 182, 104 );
      this.m_ButtonClose.Name = "m_ButtonClose";
      this.m_ButtonClose.Size = new System.Drawing.Size( 75, 23 );
      this.m_ButtonClose.TabIndex = 9;
      this.m_ButtonClose.Text = "Close";
      this.m_ButtonClose.UseVisualStyleBackColor = true;
      this.m_ButtonClose.Click += new System.EventHandler( this.ButtonCloseClick );
      // 
      // NumberForm
      // 
      this.AcceptButton = this.m_ButtonClose;
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size( 299, 141 );
      this.Controls.Add( this.m_ButtonClose );
      this.Controls.Add( this.m_ButtonCopyBin );
      this.Controls.Add( this.m_TextBoxBin );
      this.Controls.Add( this.label3 );
      this.Controls.Add( this.m_ButtonCopyHex );
      this.Controls.Add( this.m_TextBoxHex );
      this.Controls.Add( this.label2 );
      this.Controls.Add( this.m_ButtonCopyDec );
      this.Controls.Add( this.m_TextBoxDec );
      this.Controls.Add( this.label1 );
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "NumberForm";
      this.Text = "Number info";
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox m_TextBoxDec;
    private System.Windows.Forms.Button m_ButtonCopyDec;
    private System.Windows.Forms.ToolTip m_ToolTip;
    private System.Windows.Forms.Button m_ButtonCopyHex;
    private System.Windows.Forms.TextBox m_TextBoxHex;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button m_ButtonCopyBin;
    private System.Windows.Forms.TextBox m_TextBoxBin;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button m_ButtonClose;
  }
}