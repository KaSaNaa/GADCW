using Online_Evaluation_System.Lecturer_usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Evaluation_System
{
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addNewQuestion1.Visible = true;
            addNewQuestion1.BringToFront();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            addNewQuestion1.Visible = false;
        }
    }
}
