namespace WindowsFormsApp1
{
    partial class ViewFilesForm
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
            this.DocumentTableView = new System.Windows.Forms.DataGridView();
            this.documentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learningPlatformDataSet2 = new WindowsFormsApp1.LearningPlatformDataSet2();
            this.Btn_Uploadfile = new System.Windows.Forms.Button();
            this.documentsTableAdapter = new WindowsFormsApp1.LearningPlatformDataSet2TableAdapters.documentsTableAdapter();
            this.Btn_DeleteFIle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningPlatformDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentTableView
            // 
            this.DocumentTableView.AllowUserToAddRows = false;
            this.DocumentTableView.AllowUserToDeleteRows = false;
            this.DocumentTableView.AllowUserToOrderColumns = true;
            this.DocumentTableView.AutoGenerateColumns = false;
            this.DocumentTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DocumentTableView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DocumentTableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocumentTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentDataGridViewTextBoxColumn});
            this.DocumentTableView.DataSource = this.documentsBindingSource;
            this.DocumentTableView.Dock = System.Windows.Forms.DockStyle.Left;
            this.DocumentTableView.Location = new System.Drawing.Point(20, 60);
            this.DocumentTableView.Name = "DocumentTableView";
            this.DocumentTableView.ReadOnly = true;
            this.DocumentTableView.RowHeadersWidth = 45;
            this.DocumentTableView.Size = new System.Drawing.Size(298, 370);
            this.DocumentTableView.TabIndex = 0;
            this.DocumentTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocumentTableView_CellContentClick);
            // 
            // documentDataGridViewTextBoxColumn
            // 
            this.documentDataGridViewTextBoxColumn.DataPropertyName = "document";
            this.documentDataGridViewTextBoxColumn.HeaderText = "document";
            this.documentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentDataGridViewTextBoxColumn.Name = "documentDataGridViewTextBoxColumn";
            this.documentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "documents";
            this.documentsBindingSource.DataSource = this.learningPlatformDataSet2;
            // 
            // learningPlatformDataSet2
            // 
            this.learningPlatformDataSet2.DataSetName = "LearningPlatformDataSet2";
            this.learningPlatformDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Uploadfile
            // 
            this.Btn_Uploadfile.Location = new System.Drawing.Point(486, 59);
            this.Btn_Uploadfile.Name = "Btn_Uploadfile";
            this.Btn_Uploadfile.Size = new System.Drawing.Size(105, 23);
            this.Btn_Uploadfile.TabIndex = 1;
            this.Btn_Uploadfile.Text = "Upload a file";
            this.Btn_Uploadfile.UseVisualStyleBackColor = true;
            this.Btn_Uploadfile.Click += new System.EventHandler(this.Btn_Uploadfile_Click);
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_DeleteFIle
            // 
            this.Btn_DeleteFIle.Location = new System.Drawing.Point(372, 153);
            this.Btn_DeleteFIle.Name = "Btn_DeleteFIle";
            this.Btn_DeleteFIle.Size = new System.Drawing.Size(75, 23);
            this.Btn_DeleteFIle.TabIndex = 2;
            this.Btn_DeleteFIle.Text = "Delete file";
            this.Btn_DeleteFIle.UseVisualStyleBackColor = true;
            // 
            // ViewFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_DeleteFIle);
            this.Controls.Add(this.Btn_Uploadfile);
            this.Controls.Add(this.DocumentTableView);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ViewFilesForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Form2";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningPlatformDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DocumentTableView;
        private System.Windows.Forms.Button Btn_Uploadfile;
        private LearningPlatformDataSet2 learningPlatformDataSet2;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private LearningPlatformDataSet2TableAdapters.documentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_DeleteFIle;
    }
}