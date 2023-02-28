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
                long id;
                bool success = long.TryParse(ds.Tables[0].Rows[0][0].ToString(), out id);
                if (success)
                {
                    txt_activity.Text = (id + 1).ToString();
                }
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

            query = "select * from Questions where activity = '" + activity + "' and question = '" + question + "' and option1 = '" + option1 + "' and option2 = '" + option2 + "' and option3 = '" + option3 + "' and option4 = '" + option4 + "' and ans = '" + ans + "'";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This question already exists in the " + activity + " activity set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(question) || string.IsNullOrWhiteSpace(option1) || string.IsNullOrWhiteSpace(option2) || string.IsNullOrWhiteSpace(option3) || string.IsNullOrWhiteSpace(option4) || string.IsNullOrWhiteSpace(ans))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ans != option1 && ans != option2 && ans != option3 && ans != option4)
            {
                MessageBox.Show("Answer does not match any of the options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int activityValue;
            if (!int.TryParse(activity, out activityValue) || activityValue <= 0)
            {
                MessageBox.Show("Invalid activity value. Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_activity.Clear();
                txt_activity.Focus();
                return;
            }

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
            
            long activity;
                if (long.TryParse(txt_activity.Text, out activity))
                {
                    if (activity == 0)
                    {
                        MessageBox.Show("Cannot enter 0. Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_activity.Clear();
                        txt_activity.Focus();
                        return;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid activity value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_activity.Clear();
                    txt_activity.Focus();
                    return;
                }

            

            if (MessageBox.Show("Set Will be Changed", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txt_activity.Text = (activity + 1).ToString();
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

                if (!System.Text.RegularExpressions.Regex.IsMatch(txt_activity.Text, "^[0-9]*$"))
                {
                    lbl_error.Text = "Error: Only numbers are allowed";
                    lbl_error.Visible = true;
                    txt_activity.Focus();
                }
                else if (txt_activity.Text == "0")
                {
                    lbl_error.Text = "Error: 0 cannot be inserted";
                    lbl_error.Visible = true;
                    txt_activity.Focus();
                }
                else
                {
                    lbl_error.Text = "";
                    lbl_error.Visible = true;
                    txt_activity.Focus();
                }

            }
        }
    }
}
