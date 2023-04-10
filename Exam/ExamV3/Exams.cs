using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_System
{
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
            //MultiRandom();
            FetchQuestions();
            timer1.Start();

            stud_Lbl.Text = Login.StudName;
            Subject_Lbl.Text = Login.SubjName;
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Exam;Integrated Security=true");
        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        private int GenrateRandom()
        {
            Random rd = new Random();
            int x = rd.Next(1, 2);
            int y = rd.Next(1, 2);
            int z = rd.Next(1, 2);
            MessageBox.Show("" + x + " and " + y + " and " + z);
            return x;

        }

        int[] keys = new int[10];
        private void MultiRandom()
        {
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count < 10)
            {
                numbers.Add(rnd.Next(1, 14));
            }
            for (int i = 0; i < 10; i++)
            {
                keys[i] = numbers.ElementAt(i);
            }
        }
        private void FetchQuestions()
        {
            try
            {
                //int Qnum=GenrateRandom();
                MultiRandom();
                con.Open();
                string Query = "select* from QuestionsTbl where QId=" + keys[0] + "";
                SqlCommand cmd = new SqlCommand(Query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question1.Text = dr["QDesc"].ToString();
                    Q1O1.Text = dr["QOption1"].ToString();
                    Q1O2.Text = dr["QOption2"].ToString();
                    Q1O3.Text = dr["QOption3"].ToString();
                    Q1O4.Text = dr["QOption4"].ToString();
                    a1 = dr["QAnswer"].ToString();
                }

                #region Question 2
                string Query2 = "select* from QuestionsTbl where QId=" + keys[1] + "";
                cmd = new SqlCommand(Query2, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question2.Text = dr["QDesc"].ToString();
                    Q2O1.Text = dr["QOption1"].ToString();
                    Q2O2.Text = dr["QOption2"].ToString();
                    Q2O3.Text = dr["QOption3"].ToString();
                    Q2O4.Text = dr["QOption4"].ToString();
                    a2 = dr["QAnswer"].ToString();
                }
                #endregion

                #region Question 3
                string Query3 = "select* from QuestionsTbl where QId=" + keys[2] + "";
                cmd = new SqlCommand(Query3, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question3.Text = dr["QDesc"].ToString();
                    Q3O1.Text = dr["QOption1"].ToString();
                    Q3O2.Text = dr["QOption2"].ToString();
                    Q3O3.Text = dr["QOption3"].ToString();
                    Q3O4.Text = dr["QOption4"].ToString();
                    a3 = dr["QAnswer"].ToString();
                }
                #endregion

                #region Question 4
                string Query4 = "select* from QuestionsTbl where QId=" + keys[3] + "";
                cmd = new SqlCommand(Query4, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question4.Text = dr["QDesc"].ToString();
                    Q4O1.Text = dr["QOption1"].ToString();
                    Q4O2.Text = dr["QOption2"].ToString();
                    Q4O3.Text = dr["QOption3"].ToString();
                    Q4O4.Text = dr["QOption4"].ToString();
                    a4 = dr["QAnswer"].ToString();
                }
                #endregion

                #region Question 5
                string Query5 = "select* from QuestionsTbl where QId=" + keys[4] + "";
                cmd = new SqlCommand(Query5, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question5.Text = dr["QDesc"].ToString();
                    Q5O1.Text = dr["QOption1"].ToString();
                    Q5O2.Text = dr["QOption2"].ToString();
                    Q5O3.Text = dr["QOption3"].ToString();
                    Q5O4.Text = dr["QOption4"].ToString();
                    a5 = dr["QAnswer"].ToString();
                }
                #endregion

                #region Question 6
                string Query6 = "select* from QuestionsTbl where QId=" + keys[5] + "";
                cmd = new SqlCommand(Query6, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question6.Text = dr["QDesc"].ToString();
                    Q6O1.Text = dr["QOption1"].ToString();
                    Q6O2.Text = dr["QOption2"].ToString();
                    Q6O3.Text = dr["QOption3"].ToString();
                    Q6O4.Text = dr["QOption4"].ToString();
                    a6 = dr["QAnswer"].ToString();
                }
                #endregion

                #region Question 7
                string Query7 = "select* from QuestionsTbl where QId=" + keys[6] + "";
                cmd = new SqlCommand(Query7, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question7.Text = dr["QDesc"].ToString();
                    Q7O1.Text = dr["QOption1"].ToString();
                    Q7O2.Text = dr["QOption2"].ToString();
                    Q7O3.Text = dr["QOption3"].ToString();
                    Q7O4.Text = dr["QOption4"].ToString();
                    a7 = dr["QAnswer"].ToString();
                }
                #endregion

                #region Question 8
                string Query8 = "select* from QuestionsTbl where QId=" + keys[7] + "";
                cmd = new SqlCommand(Query8, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question8.Text = dr["QDesc"].ToString();
                    Q8O1.Text = dr["QOption1"].ToString();
                    Q8O2.Text = dr["QOption2"].ToString();
                    Q8O3.Text = dr["QOption3"].ToString();
                    Q8O4.Text = dr["QOption4"].ToString();
                    a8 = dr["QAnswer"].ToString();
                }
                #endregion

                #region Question 9
                string Query9 = "select* from QuestionsTbl where QId=" + keys[8] + "";
                cmd = new SqlCommand(Query9, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question9.Text = dr["QDesc"].ToString();
                    Q9O1.Text = dr["QOption1"].ToString();
                    Q9O2.Text = dr["QOption2"].ToString();
                    Q9O3.Text = dr["QOption3"].ToString();
                    Q9O4.Text = dr["QOption4"].ToString();
                    a9 = dr["QAnswer"].ToString();
                }
                #endregion

                #region Question 10
                string Query10 = "select* from QuestionsTbl where QId=" + keys[9] + "";
                cmd = new SqlCommand(Query10, con);
                dt = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_Question10.Text = dr["QDesc"].ToString();
                    Q10O1.Text = dr["QOption1"].ToString();
                    Q10O2.Text = dr["QOption2"].ToString();
                    Q10O3.Text = dr["QOption3"].ToString();
                    Q10O4.Text = dr["QOption4"].ToString();
                    a10 = dr["QAnswer"].ToString();
                }
                #endregion


                con.Close();

            }
            catch (Exception e)
            {

            }
        }

        int count = 300;
        private void timer1_Tick(object sender, EventArgs e)
        {
            --count; ;
            
            progressBar1.Value = ++count;
          
            if (progressBar1.Value == 0)
            {
                progressBar1.Value = 300;
                timer1.Stop();
                MessageBox.Show("Time Out");
                Login log = new Login();
                log.Show();
                this.Hide();

            }
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }
        int score = 0;
        string[] Ua = new string[10];

        #region Check Question
        private void checkQ1()
        {
            if (Q1O1.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O1.Text;
            }
            else if (Q1O2.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O2.Text;
            }
            else if (Q1O3.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O3.Text;
            }
            else if (Q1O4.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O4.Text;
            }

            if (Ua[0] == a1)
            {
                score += 1;
            }
            else
            {
                // score = score;
            }
        }
        private void checkQ2()
        {
            if (Q2O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O1.Text;
            }
            else if (Q2O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O2.Text;
            }
            else if (Q2O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O3.Text;
            }
            else if (Q2O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O4.Text;
            }

            if (Ua[1] == a2)
            {
                score += 1;
            }
            else
            {
                // score = score;
            }
        }
        private void checkQ3()
        {
            if (Q3O1.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O1.Text;
            }
            else if (Q3O2.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O2.Text;
            }
            else if (Q3O3.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O3.Text;
            }
            else if (Q3O4.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O4.Text;
            }

            if (Ua[2] == a3)
            {
                score += 1;
            }
            else
            {
                // score = score;
            }
        }
        private void checkQ4()
        {
            if (Q4O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q4O1.Text;
            }
            else if (Q4O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q4O2.Text;
            }
            else if (Q4O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q4O3.Text;
            }
            else if (Q4O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q4O4.Text;
            }

            if (Ua[1] == a4)
            {
                score += 1;
            }
            else
            {
                // score = score;
            }
        }
        private void checkQ5()
        {
            if (Q5O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q5O1.Text;
            }
            else if (Q5O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q5O2.Text;
            }
            else if (Q5O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q5O3.Text;
            }
            else if (Q5O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q5O4.Text;
            }

            if (Ua[1] == a5)
            {
                score += 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ6()
        {
            if (Q6O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q6O1.Text;
            }
            else if (Q6O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q6O2.Text;
            }
            else if (Q6O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q6O3.Text;
            }
            else if (Q6O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q6O4.Text;
            }

            if (Ua[1] == a6)
            {
                score += 1;
            }
            else
            {
                // score = score;
            }
        }
        private void checkQ7()
        {
            if (Q7O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q7O1.Text;
            }
            else if (Q7O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q7O2.Text;
            }
            else if (Q7O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q7O3.Text;
            }
            else if (Q7O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q7O4.Text;
            }

            if (Ua[1] == a7)
            {
                score += 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ8()
        {
            if (Q8O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q8O1.Text;
            }
            else if (Q8O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q8O2.Text;
            }
            else if (Q8O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q8O3.Text;
            }
            else if (Q8O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q8O4.Text;
            }

            if (Ua[1] == a8)
            {
                score += 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ9()
        {
            if (Q9O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q9O1.Text;
            }
            else if (Q9O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q9O2.Text;
            }
            else if (Q9O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q9O3.Text;
            }
            else if (Q9O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q9O4.Text;
            }

            if (Ua[1] == a9)
            {
                score += 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ10()
        {
            if (Q10O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q10O1.Text;
            }
            else if (Q10O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q10O2.Text;
            }
            else if (Q10O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q10O3.Text;
            }
            else if (Q10O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q10O4.Text;
            }

            if (Ua[1] == a10)
            {
                score += 1;
            }
            else
            {
                // score = score;
            }
        }
        #endregion

        private void InsertResult()
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ResultTbl  (ResSubject,ResStudent,ResDate,ResTime,ResScore) values(@RS,@RStu,@RD,@RT,@RSstu)", con);
                cmd.Parameters.AddWithValue("@RS", Subject_Lbl.Text);
                cmd.Parameters.AddWithValue("@RStu", stud_Lbl.Text);
                cmd.Parameters.AddWithValue("@RD", QDateP.Value.Date);
                cmd.Parameters.AddWithValue("@RT", QTimeP.Text);
                cmd.Parameters.AddWithValue("@RSstu", score);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Result Saved");

                con.Close();
                // Reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Reset()
        {

        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            score = 0;
            checkQ1();
            checkQ2();
            checkQ3();
            checkQ4();
            checkQ5();
            checkQ6();
            checkQ7();
            checkQ8();
            checkQ9();
            checkQ10();
            MessageBox.Show("" + score);
            InsertResult();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private int CountQuestion()
        {
            int Qnum;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from QuestionsTbl where Q5 ='" + Subject_Lbl.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Qnum = Convert.ToInt32(dt.Rows[0][0]);
            con.Close();
            MessageBox.Show("" + Qnum);
            return Qnum;
        }
        private void Q1O1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q1O2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Subject_Lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
