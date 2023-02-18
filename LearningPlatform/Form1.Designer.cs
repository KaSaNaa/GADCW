namespace LearningPlatform
{
    partial class Form1
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
            this.Btn_UploadFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_UploadFiles
            // 
            this.Btn_UploadFiles.Location = new System.Drawing.Point(307, 186);
            this.Btn_UploadFiles.Name = "Btn_UploadFiles";
            this.Btn_UploadFiles.Size = new System.Drawing.Size(126, 23);
            this.Btn_UploadFiles.TabIndex = 0;
            this.Btn_UploadFiles.Text = "Upload files";
            this.Btn_UploadFiles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_UploadFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_UploadFiles;
    }
}

