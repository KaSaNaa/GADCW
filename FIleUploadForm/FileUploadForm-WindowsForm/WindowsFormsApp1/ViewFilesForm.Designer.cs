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
            this.learningPlatformDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learningPlatformDataSet = new WindowsFormsApp1.LearningPlatformDataSet();
            this.Btn_Uploadfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningPlatformDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningPlatformDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentTableView
            // 
            this.DocumentTableView.AllowUserToOrderColumns = true;
            this.DocumentTableView.AutoGenerateColumns = false;
            this.DocumentTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentTableView.DataSource = this.learningPlatformDataSetBindingSource;
            this.DocumentTableView.Dock = System.Windows.Forms.DockStyle.Left;
            this.DocumentTableView.Location = new System.Drawing.Point(0, 0);
            this.DocumentTableView.Name = "DocumentTableView";
            this.DocumentTableView.RowHeadersWidth = 45;
            this.DocumentTableView.Size = new System.Drawing.Size(306, 450);
            this.DocumentTableView.TabIndex = 0;
            this.DocumentTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocumentTableView_CellContentClick);
            // 
            // learningPlatformDataSetBindingSource
            // 
            this.learningPlatformDataSetBindingSource.DataSource = this.learningPlatformDataSet;
            this.learningPlatformDataSetBindingSource.Position = 0;
            // 
            // learningPlatformDataSet
            // 
            this.learningPlatformDataSet.DataSetName = "LearningPlatformDataSet";
            this.learningPlatformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Uploadfile
            // 
            this.Btn_Uploadfile.Location = new System.Drawing.Point(482, 178);
            this.Btn_Uploadfile.Name = "Btn_Uploadfile";
            this.Btn_Uploadfile.Size = new System.Drawing.Size(105, 23);
            this.Btn_Uploadfile.TabIndex = 1;
            this.Btn_Uploadfile.Text = "Upload a file";
            this.Btn_Uploadfile.UseVisualStyleBackColor = true;
            this.Btn_Uploadfile.Click += new System.EventHandler(this.Btn_Uploadfile_Click);
            // 
            // ViewFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Uploadfile);
            this.Controls.Add(this.DocumentTableView);
            this.Name = "ViewFilesForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningPlatformDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningPlatformDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DocumentTableView;
        private LearningPlatformDataSet learningPlatformDataSet;
        private System.Windows.Forms.BindingSource learningPlatformDataSetBindingSource;
        private System.Windows.Forms.Button Btn_Uploadfile;
    }
}