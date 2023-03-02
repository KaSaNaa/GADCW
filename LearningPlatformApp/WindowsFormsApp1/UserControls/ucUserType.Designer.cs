namespace WindowsFormsApp1.UserControls
{
    partial class ucUserType
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUserType));
            this.mtLecturer = new MetroFramework.Controls.MetroTile();
            this.mtStudent = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtLecturer
            // 
            this.mtLecturer.ActiveControl = null;
            this.mtLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtLecturer.Location = new System.Drawing.Point(598, 208);
            this.mtLecturer.Name = "mtLecturer";
            this.mtLecturer.Size = new System.Drawing.Size(252, 227);
            this.mtLecturer.TabIndex = 0;
            this.mtLecturer.Text = "Lecturer";
            this.mtLecturer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtLecturer.TileImage = ((System.Drawing.Image)(resources.GetObject("mtLecturer.TileImage")));
            this.mtLecturer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtLecturer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtLecturer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtLecturer.UseSelectable = true;
            this.mtLecturer.UseTileImage = true;
            this.mtLecturer.Click += new System.EventHandler(this.mtLecturer_Click);
            // 
            // mtStudent
            // 
            this.mtStudent.ActiveControl = null;
            this.mtStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtStudent.Location = new System.Drawing.Point(287, 208);
            this.mtStudent.Name = "mtStudent";
            this.mtStudent.Size = new System.Drawing.Size(252, 227);
            this.mtStudent.TabIndex = 0;
            this.mtStudent.Text = "Student";
            this.mtStudent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtStudent.TileImage = ((System.Drawing.Image)(resources.GetObject("mtStudent.TileImage")));
            this.mtStudent.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtStudent.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtStudent.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtStudent.UseSelectable = true;
            this.mtStudent.UseTileImage = true;
            this.mtStudent.Click += new System.EventHandler(this.mtStudent_Click);
            // 
            // ucUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtStudent);
            this.Controls.Add(this.mtLecturer);
            this.Name = "ucUserType";
            this.Size = new System.Drawing.Size(1136, 642);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtLecturer;
        private MetroFramework.Controls.MetroTile mtStudent;
    }
}
