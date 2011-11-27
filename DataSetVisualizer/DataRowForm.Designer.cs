namespace Hackovic.VisualStudio
{
  partial class DataRowForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataRowForm));
      this.m_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.SuspendLayout();
      // 
      // m_TableLayoutPanel
      // 
      this.m_TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_TableLayoutPanel.AutoScroll = true;
      this.m_TableLayoutPanel.ColumnCount = 2;
      this.m_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.m_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.m_TableLayoutPanel.Location = new System.Drawing.Point(7, 12);
      this.m_TableLayoutPanel.Name = "m_TableLayoutPanel";
      this.m_TableLayoutPanel.RowCount = 1;
      this.m_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.m_TableLayoutPanel.Size = new System.Drawing.Size(603, 551);
      this.m_TableLayoutPanel.TabIndex = 0;
      // 
      // DataRowForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(622, 575);
      this.Controls.Add(this.m_TableLayoutPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DataRowForm";
      this.Text = "Data Row Visualizer";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel m_TableLayoutPanel;
  }
}