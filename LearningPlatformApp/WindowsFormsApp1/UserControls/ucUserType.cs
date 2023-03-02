using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucUserType : MetroFramework.Controls.MetroUserControl
    {
        public ucUserType()
        {
            InitializeComponent();
        }

        private void mtStudent_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucStudentSignIn"))
            {
                var uc = new ucStudentSignIn();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucStudentSignIn"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mtLecturer_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucLecturerSignIn"))
            {
                var uc = new ucLecturerSignIn();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucLecturerSignIn"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }
    }
}
