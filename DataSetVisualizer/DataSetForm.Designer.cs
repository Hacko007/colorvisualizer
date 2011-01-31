namespace DataSetVisualizer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_ComboBox = new System.Windows.Forms.ComboBox();
            this.buttonExportTable = new System.Windows.Forms.Button();
            this.buttonExportDataset = new System.Windows.Forms.Button();
            this.labelTable = new System.Windows.Forms.Label();
            this.m_DataGridView = new System.Windows.Forms.DataGridView();
            this.m_BindingSourceDataSet = new System.Windows.Forms.BindingSource(this.components);
            this.m_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTable);
            this.panel1.Controls.Add(this.buttonExportDataset);
            this.panel1.Controls.Add(this.buttonExportTable);
            this.panel1.Controls.Add(this.m_ComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 67);
            this.panel1.TabIndex = 0;
            // 
            // m_ComboBox
            // 
            this.m_ComboBox.FormattingEnabled = true;
            this.m_ComboBox.Location = new System.Drawing.Point(12, 31);
            this.m_ComboBox.Name = "m_ComboBox";
            this.m_ComboBox.Size = new System.Drawing.Size(287, 21);
            this.m_ComboBox.TabIndex = 0;
            this.m_ComboBox.SelectedIndexChanged += new System.EventHandler(this.m_ComboBox_SelectedIndexChanged);
            // 
            // buttonExportTable
            // 
            this.buttonExportTable.Location = new System.Drawing.Point(305, 29);
            this.buttonExportTable.Name = "buttonExportTable";
            this.buttonExportTable.Size = new System.Drawing.Size(122, 23);
            this.buttonExportTable.TabIndex = 1;
            this.buttonExportTable.Text = "Export table";
            this.buttonExportTable.UseVisualStyleBackColor = true;
            this.buttonExportTable.Click += new System.EventHandler(this.buttonExportTable_Click);
            // 
            // buttonExportDataset
            // 
            this.buttonExportDataset.Location = new System.Drawing.Point(434, 28);
            this.buttonExportDataset.Name = "buttonExportDataset";
            this.buttonExportDataset.Size = new System.Drawing.Size(146, 23);
            this.buttonExportDataset.TabIndex = 2;
            this.buttonExportDataset.Text = "Export dataset";
            this.buttonExportDataset.UseVisualStyleBackColor = true;
            this.buttonExportDataset.Click += new System.EventHandler(this.buttonExportDataset_Click);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(13, 13);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(68, 13);
            this.labelTable.TabIndex = 3;
            this.labelTable.Text = "Table names";
            // 
            // m_DataGridView
            // 
            this.m_DataGridView.AllowUserToAddRows = false;
            this.m_DataGridView.AllowUserToDeleteRows = false;
            this.m_DataGridView.AutoGenerateColumns = false;
            this.m_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_DataGridView.DataSource = this.m_BindingSourceDataSet;
            this.m_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_DataGridView.Location = new System.Drawing.Point(0, 67);
            this.m_DataGridView.Name = "m_DataGridView";
            this.m_DataGridView.ReadOnly = true;
            this.m_DataGridView.Size = new System.Drawing.Size(832, 306);
            this.m_DataGridView.TabIndex = 1;
            // 
            // m_SaveFileDialog
            // 
            this.m_SaveFileDialog.DefaultExt = "xml";
            this.m_SaveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.m_SaveFileDialog.Title = "Save as XML";
            // 
            // DataSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 373);
            this.Controls.Add(this.m_DataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "DataSetForm";
            this.Text = "DataSetForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Button buttonExportDataset;
        private System.Windows.Forms.Button buttonExportTable;
        private System.Windows.Forms.ComboBox m_ComboBox;
        private System.Windows.Forms.DataGridView m_DataGridView;
        private System.Windows.Forms.BindingSource m_BindingSourceDataSet;
        private System.Windows.Forms.SaveFileDialog m_SaveFileDialog;
    }
}