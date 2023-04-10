using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Exam_System
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
            dataGrid_QuestionBank.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Exam;Integrated Security=true");

        public void GetSubjects()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select SubjName from SubjectTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SubjName", typeof(string));
            dt.Load(rdr);
            com_Subject.ValueMember = "SubjName";
            com_Subject.DataSource = dt;

            con.Close();
        }

        private void lab_Question_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions();
            questions.Show();
            this.Hide();
        }

        private void lab_Subject_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void lab_Student_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }
        public void Reset()
        {
            txt_question.Text = "";
            txt_option1.Text = "";
            txt_option2.Text = "";
            txt_option3.Text = "";
            txt_option4.Text = "";
            txt_option5.Text = "";

        }
        public void DisplayQuestions()
        {
            con.Open();
            string Query = "select *from QuestionsTbl";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGrid_QuestionBank.DataSource = dataSet.Tables[0];
            con.Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_question.Text == "" || txt_option1.Text == "" || txt_option2.Text == "" || txt_option3.Text == "" || txt_option4.Text == "" || txt_option5.Text == "")
            {
                MessageBox.Show("Missing Infoemation");
            }
            else
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into QuestionsTbl  (QDesc,QOption1,QOption2,QOption3,QOption4,QAnswer,Q5) values(@Qd,@O1,@O2,@O3,@O4,@Qan,@Qsu)", con);
                    cmd.Parameters.AddWithValue("@Qd", txt_question.Text);
                    cmd.Parameters.AddWithValue("@O1", txt_option1.Text);
                    cmd.Parameters.AddWithValue("@O2", txt_option2.Text);
                    cmd.Parameters.AddWithValue("@O3", txt_option3.Text);
                    cmd.Parameters.AddWithValue("@O4", txt_option4.Text);
                    cmd.Parameters.AddWithValue("@Qan", txt_option5.Text);
                    cmd.Parameters.AddWithValue("@Qsu", com_Subject.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Added");

                    con.Close();
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dataGrid_QuestionBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGrid_StudentList.ColumnCount = 10;
            txt_question.Text = (dataGrid_QuestionBank.SelectedRows[0].Cells[1].Value).ToString();
            txt_option1.Text = (dataGrid_QuestionBank.SelectedRows[0].Cells[2].Value).ToString();
            txt_option2.Text = (dataGrid_QuestionBank.SelectedRows[0].Cells[3].Value).ToString();
            txt_option3.Text = (dataGrid_QuestionBank.SelectedRows[0].Cells[4].Value).ToString();
            txt_option4.Text = (dataGrid_QuestionBank.SelectedRows[0].Cells[5].Value).ToString();
            txt_option5.Text = (dataGrid_QuestionBank.SelectedRows[0].Cells[6].Value).ToString();
            com_Subject.SelectedValue = (dataGrid_QuestionBank.SelectedRows[0].Cells[7].Value).ToString();
            if (txt_question.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGrid_QuestionBank.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        int Key = 0;

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_question.Text == "" || txt_option1.Text == "" || txt_option2.Text == "" || txt_option3.Text == "" || txt_option4.Text == "" || txt_option5.Text == "")
            {
                MessageBox.Show("Missing Infoemation");
            }
            else
            {
                try
                {
                    int Score = 0;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update  QuestionsTbl set QDesc=@Qd,QOption1=@O1,QOption2=@O2,QOption3=@O3,QOption4=@O4,QAnswer=@Qan,Q5=@Qsu  where QId=@Qkey", con);
                    cmd.Parameters.AddWithValue("@Qd", txt_question.Text);
                    cmd.Parameters.AddWithValue("@O1", txt_option1.Text);
                    cmd.Parameters.AddWithValue("@O2", txt_option2.Text);
                    cmd.Parameters.AddWithValue("@O3", txt_option3.Text);
                    cmd.Parameters.AddWithValue("@O4", txt_option4.Text);
                    cmd.Parameters.AddWithValue("@Qan", txt_option5.Text);
                    cmd.Parameters.AddWithValue("@Qsu", com_Subject.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Qkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Updated");

                    con.Close();
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pic_Educating_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            obj.Show();
            this.Hide();
        }

        private void pic_programming_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void pic_reporting_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }
    }
}
