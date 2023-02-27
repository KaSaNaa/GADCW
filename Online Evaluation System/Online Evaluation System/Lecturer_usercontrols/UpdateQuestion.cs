using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Evaluation_System.Lecturer_usercontrols
{
    public partial class UpdateQuestion : UserControl

    {
        Function fn = new Function();
        String query;

        public UpdateQuestion()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {
            cmb_activity.Items.Clear();
            query = "select distinct activity from Questions";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb_activity.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void cmb_activity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_questionNo.Items.Clear();
            query = ("select qno from Questions where activity = '" + cmb_activity.Text + "'");
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb_questionNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}