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
    public partial class AddNewQuestion : UserControl
    {

        Function fn = new Function();
        String query;
        DataSet ds;
        Int64 questionNo = 1;

        public AddNewQuestion()
        {
            InitializeComponent();
        }

        private void lbl_questionNo_Click(object sender, EventArgs e)
        {

        }

        private void txt_option4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewQuestion_Load(object sender, EventArgs e)
        {
            query = "select max(activity) from Questions";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString()!="")
            {
                Int64 id = Convert.ToInt64(ds.Tables[0].Rows[0][0].ToString());
                txt_activity.Text = (id+1).ToString();
            }
            else
            {
                txt_activity.Text = "1";
            }
            lbl_questionNo.Text = questionNo.ToString();
            lbl_error.Visible = false;


        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            String activity = txt_activity.Text;
            String qno = questionNo.ToString();
            String question = txt_question.Text;
            String option1 = txt_option1.Text;
            String option2 = txt_option2.Text;
            String option3 = txt_option3.Text;
            String option4 = txt_option4.Text;
            String ans = txt_answer.Text;

            query = "insert into Questions(activity, qno, question, option1, option2, option3, option4, ans) values('" + activity + "','" + qno + "','" + question + "','" + option1 + "','" + option2 + "','" + option3 + "','" + option4 + "','" + ans + "')";
            fn.setData(query, "Question added");

            clearAll();
            questionNo++;
            lbl_questionNo.Text = questionNo.ToString();


            
        }

        public void clearAll()
        {
            txt_question.Clear();
            txt_option1.Clear();
            txt_option2.Clear();
            txt_option3.Clear();
            txt_option4.Clear();
            txt_answer.Clear();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Unsaved Data Will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Set Will be Changed", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txt_activity.Text = (Convert.ToInt64(txt_activity.Text.ToString()) + 1).ToString();
                lbl_questionNo.Text = "1";
            }
        }

        private void txt_activity_TextChanged(object sender, EventArgs e)
        {
            if(txt_activity.Text!="")
            {
                clearAll();
                query = "select qno from Questions where activity = '" + txt_activity.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count!=0 && ds.Tables[0].Rows[0][0].ToString()!="")
                {
                    lbl_questionNo.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Convert.ToInt64(lbl_questionNo.Text.ToString());
                }
                else
                {
                    lbl_questionNo.Text="1";
                    questionNo = Convert.ToInt64(lbl_questionNo.Text.ToString());
                   
                }
            }
        }
    }
}
