using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebFormUsingC
{
    public partial class CreateQuestionPaper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void radOption1_CheckedChanged(object sender, EventArgs e)
        {
            radOption1.Checked = true;
            radOption2.Checked = false;
            radOption3.Checked = false;
            radOption4.Checked = false;
        }

        protected void radOption2_CheckedChanged(object sender, EventArgs e)
        {
            radOption1.Checked = false;
            radOption2.Checked = true;
            radOption3.Checked = false;
            radOption4.Checked = false;
        }

        protected void radOption3_CheckedChanged(object sender, EventArgs e)
        {
            radOption1.Checked = false;
            radOption2.Checked = false;
            radOption3.Checked = true;
            radOption4.Checked = false;
        }

        protected void radOption4_CheckedChanged(object sender, EventArgs e)
        {
            radOption1.Checked = false;
            radOption2.Checked = false;
            radOption3.Checked = false;
            radOption4.Checked = true;
        }

        protected void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            Question question = new Question()
            {
                Option1 = txtOption1.Text.Trim(),
                Option2 = txtOption2.Text.Trim(),
                Option3 = txtOption2.Text.Trim(),
                Option4 = txtOption4.Text.Trim(),
                QuestionText = txtQuestion.Text.Trim()
            };
            question = SetAnswer(question);

        }
        public Question InsertQuestionAndOptionDetails(Question question)
        {
            string connectionString = ConfigurationSettings.AppSettings.Get("Connection");
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {

                }
            }
            return question;
        }
        public Question SetAnswer(Question question)
        {
            if (radOption1.Checked)
                question.CorrectAnswer = txtOption1.Text.Trim();
            else if (radOption2.Checked)
                question.CorrectAnswer = txtOption2.Text.Trim();
            else if (radOption3.Checked)
                question.CorrectAnswer = txtOption3.Text.Trim();
            else if (radOption4.Checked)
                question.CorrectAnswer = txtOption4.Text.Trim();
            return question;
        }
    }
}