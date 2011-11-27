namespace Hackovic.VisualStudio
{
  partial class DataGridViewRowForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewRowForm));
      this.m_PropertyGrid = new System.Windows.Forms.PropertyGrid();
      this.m_DataGridViewCells = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewCells)).BeginInit();
      this.SuspendLayout();
      // 
      // m_PropertyGrid
      // 
      this.m_PropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_PropertyGrid.HelpVisible = false;
      this.m_PropertyGrid.Location = new System.Drawing.Point(12, 12);
      this.m_PropertyGrid.Name = "m_PropertyGrid";
      this.m_PropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
      this.m_PropertyGrid.Size = new System.Drawing.Size(637, 127);
      this.m_PropertyGrid.TabIndex = 0;
      // 
      // m_DataGridViewCells
      // 
      this.m_DataGridViewCells.AllowUserToAddRows = false;
      this.m_DataGridViewCells.AllowUserToDeleteRows = false;
      this.m_DataGridViewCells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_DataGridViewCells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.m_DataGridViewCells.Location = new System.Drawing.Point(13, 146);
      this.m_DataGridViewCells.Name = "m_DataGridViewCells";
      this.m_DataGridViewCells.ReadOnly = true;
      this.m_DataGridViewCells.Size = new System.Drawing.Size(636, 351);
      this.m_DataGridViewCells.TabIndex = 1;
      this.m_DataGridViewCells.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridViewCellsDataError);
      // 
      // DataGridViewRowForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(661, 509);
      this.Controls.Add(this.m_DataGridViewCells);
      this.Controls.Add(this.m_PropertyGrid);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DataGridViewRowForm";
      this.Text = "DataGridViewRow Visualizer";
      ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewCells)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PropertyGrid m_PropertyGrid;
    private System.Windows.Forms.DataGridView m_DataGridViewCells;
  }
}