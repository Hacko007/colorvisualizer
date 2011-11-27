namespace Hackovic.VisualStudio
{
    partial class DataSetForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSetForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.m_labelInfo = new System.Windows.Forms.Label();
      this.m_buttonRemoveRelation = new System.Windows.Forms.Button();
      this.m_ComboBox = new System.Windows.Forms.ComboBox();
      this.m_ButtonClose = new System.Windows.Forms.Button();
      this.labelTable = new System.Windows.Forms.Label();
      this.buttonExportDataset = new System.Windows.Forms.Button();
      this.buttonExportTable = new System.Windows.Forms.Button();
      this.m_DataGridView = new System.Windows.Forms.DataGridView();
      this.m_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.m_cellContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.parentRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.childRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.filterOnCellValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_DataGridView)).BeginInit();
      this.m_cellContextMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.m_ButtonClose);
      this.panel1.Controls.Add(this.m_labelInfo);
      this.panel1.Controls.Add(this.m_buttonRemoveRelation);
      this.panel1.Controls.Add(this.m_ComboBox);
      this.panel1.Controls.Add(this.labelTable);
      this.panel1.Controls.Add(this.buttonExportDataset);
      this.panel1.Controls.Add(this.buttonExportTable);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1012, 55);
      this.panel1.TabIndex = 0;
      // 
      // m_labelInfo
      // 
      this.m_labelInfo.AutoSize = true;
      this.m_labelInfo.Location = new System.Drawing.Point(576, 28);
      this.m_labelInfo.Name = "m_labelInfo";
      this.m_labelInfo.Size = new System.Drawing.Size(0, 13);
      this.m_labelInfo.TabIndex = 4;
      // 
      // m_buttonRemoveRelation
      // 
      this.m_buttonRemoveRelation.Location = new System.Drawing.Point(510, 23);
      this.m_buttonRemoveRelation.Name = "m_buttonRemoveRelation";
      this.m_buttonRemoveRelation.Size = new System.Drawing.Size(60, 23);
      this.m_buttonRemoveRelation.TabIndex = 5;
      this.m_buttonRemoveRelation.Text = "Reset";
      this.m_ToolTip.SetToolTip(this.m_buttonRemoveRelation, "Remove relation filter");
      this.m_buttonRemoveRelation.UseVisualStyleBackColor = true;
      this.m_buttonRemoveRelation.Visible = false;
      this.m_buttonRemoveRelation.Click += new System.EventHandler(this.ButtonRemoveRelation_Click);
      // 
      // m_ComboBox
      // 
      this.m_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.m_ComboBox.FormattingEnabled = true;
      this.m_ComboBox.Location = new System.Drawing.Point(12, 25);
      this.m_ComboBox.Name = "m_ComboBox";
      this.m_ComboBox.Size = new System.Drawing.Size(287, 21);
      this.m_ComboBox.TabIndex = 1;
      this.m_ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
      // 
      // m_ButtonClose
      // 
      this.m_ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.m_ButtonClose.Location = new System.Drawing.Point(909, 23);
      this.m_ButtonClose.Name = "m_ButtonClose";
      this.m_ButtonClose.Size = new System.Drawing.Size(91, 23);
      this.m_ButtonClose.TabIndex = 6;
      this.m_ButtonClose.Text = "&Close";
      this.m_ButtonClose.UseVisualStyleBackColor = true;
      this.m_ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
      // 
      // labelTable
      // 
      this.labelTable.AutoSize = true;
      this.labelTable.Location = new System.Drawing.Point(12, 9);
      this.labelTable.Name = "labelTable";
      this.labelTable.Size = new System.Drawing.Size(68, 13);
      this.labelTable.TabIndex = 0;
      this.labelTable.Text = "Table names";
      // 
      // buttonExportDataset
      // 
      this.buttonExportDataset.Location = new System.Drawing.Point(400, 23);
      this.buttonExportDataset.Name = "buttonExportDataset";
      this.buttonExportDataset.Size = new System.Drawing.Size(104, 23);
      this.buttonExportDataset.TabIndex = 3;
      this.buttonExportDataset.Text = "Export &DataSet";
      this.m_ToolTip.SetToolTip(this.buttonExportDataset, "Export DataSet to xml");
      this.buttonExportDataset.UseVisualStyleBackColor = true;
      this.buttonExportDataset.Click += new System.EventHandler(this.ButtonExportDatasetClick);
      // 
      // buttonExportTable
      // 
      this.buttonExportTable.Location = new System.Drawing.Point(305, 23);
      this.buttonExportTable.Name = "buttonExportTable";
      this.buttonExportTable.Size = new System.Drawing.Size(89, 23);
      this.buttonExportTable.TabIndex = 2;
      this.buttonExportTable.Text = "Export &Table";
      this.m_ToolTip.SetToolTip(this.buttonExportTable, "Export selected DataTable to xml");
      this.buttonExportTable.UseVisualStyleBackColor = true;
      this.buttonExportTable.Click += new System.EventHandler(this.ButtonExportTableClick);
      // 
      // m_DataGridView
      // 
      this.m_DataGridView.AllowUserToAddRows = false;
      this.m_DataGridView.AllowUserToDeleteRows = false;
      this.m_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.m_DataGridView.Location = new System.Drawing.Point(0, 61);
      this.m_DataGridView.Name = "m_DataGridView";
      this.m_DataGridView.ReadOnly = true;
      this.m_DataGridView.Size = new System.Drawing.Size(1012, 312);
      this.m_DataGridView.TabIndex = 1;
      this.m_DataGridView.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.DataGridView_CellContextMenuStripNeeded);
      this.m_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView_DataError);
      // 
      // m_SaveFileDialog
      // 
      this.m_SaveFileDialog.DefaultExt = "xml";
      this.m_SaveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
      this.m_SaveFileDialog.Title = "Save as XML";
      // 
      // m_cellContextMenuStrip
      // 
      this.m_cellContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentRowToolStripMenuItem,
            this.childRowsToolStripMenuItem,
            this.filterOnCellValueToolStripMenuItem});
      this.m_cellContextMenuStrip.Name = "m_cellContextMenuStrip";
      this.m_cellContextMenuStrip.Size = new System.Drawing.Size(161, 92);
      // 
      // parentRowToolStripMenuItem
      // 
      this.parentRowToolStripMenuItem.Name = "parentRowToolStripMenuItem";
      this.parentRowToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
      this.parentRowToolStripMenuItem.Text = "&Parent rows";
      // 
      // childRowsToolStripMenuItem
      // 
      this.childRowsToolStripMenuItem.Name = "childRowsToolStripMenuItem";
      this.childRowsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
      this.childRowsToolStripMenuItem.Text = "&Child rows";
      // 
      // filterOnCellValueToolStripMenuItem
      // 
      this.filterOnCellValueToolStripMenuItem.Name = "filterOnCellValueToolStripMenuItem";
      this.filterOnCellValueToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
      this.filterOnCellValueToolStripMenuItem.Text = "&Filter on cell value";
      this.filterOnCellValueToolStripMenuItem.ToolTipText = "Show all rows with this cell value";
      this.filterOnCellValueToolStripMenuItem.Click += new System.EventHandler(this.OnMenuItemClick);
      // 
      // DataSetForm
      // 
      this.AcceptButton = this.m_ButtonClose;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1012, 373);
      this.Controls.Add(this.m_DataGridView);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimizeBox = false;
      this.Name = "DataSetForm";
      this.Text = "DataSetForm";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_DataGridView)).EndInit();
      this.m_cellContextMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Button buttonExportDataset;
        private System.Windows.Forms.Button buttonExportTable;
        private System.Windows.Forms.ComboBox m_ComboBox;
        private System.Windows.Forms.DataGridView m_DataGridView;
        private System.Windows.Forms.SaveFileDialog m_SaveFileDialog;
        private System.Windows.Forms.Button m_ButtonClose;
        private System.Windows.Forms.ToolTip m_ToolTip;
        private System.Windows.Forms.Label m_labelInfo;
        private System.Windows.Forms.ContextMenuStrip m_cellContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem parentRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childRowsToolStripMenuItem;
        private System.Windows.Forms.Button m_buttonRemoveRelation;
        private System.Windows.Forms.ToolStripMenuItem filterOnCellValueToolStripMenuItem;
      private bool m_disableTableListBox;
    }
}