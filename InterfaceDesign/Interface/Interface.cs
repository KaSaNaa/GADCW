using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace Interface
{
    public partial class Interface : MetroSetForm
    {
        public Interface()
        {
            InitializeComponent();
            // MetroTabControl settings
            var totalTabWidth = this.Width - 50; // Total width of the tabs, leaving 50 pixels of padding on the edges
            var numTabs = metroSetTabControl1.TabPages.Count;
            var tabWidth = totalTabWidth / numTabs; // Divide the total width by the number of tabs to get the width of each tab
            metroSetTabControl1.SizeMode = TabSizeMode.FillToRight;
            metroSetTabControl1.ItemSize = new Size(tabWidth, 30); // Set the tab width and height

            metroSetTabControl1.Dock = DockStyle.Top;
            metroSetTabControl1.Width = 300;

            metroSetTabControl1.DrawMode = TabDrawMode.Normal;
            metroSetTabControl1.Font = new Font("Huboto Sans Semi Condensed", 10);
            metroSetTabControl1.DrawMode = TabDrawMode.Normal;
            metroSetTabControl1.ItemSize = new Size(120, 60);
            metroSetTabControl1.Dock = DockStyle.Fill;

            // MetroSetControlBox settings
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.MaximizeBox = true;

            metroSetTabControl1.UseAnimation = true;
            metroSetTabControl1.AnimateTime = 200;



                var x = this.Width - this.metroSetControlBox1.Width - 10; // 10 is the padding between the form edge and the ControlBox
            this.metroSetControlBox1.Location = new Point(x, 5); // 5 is the padding between the form edge and the ControlBox


            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
