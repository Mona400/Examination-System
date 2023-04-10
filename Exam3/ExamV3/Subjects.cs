using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_System
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplayAllSubject();
            dataGrid_SubjectList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        int key = 0;
        public void Reset()
        {
            txt_SubjectName.Text = "";
            key = 0;

        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Exam;Integrated Security=true");
        public void DisplayAllSubject()
        {
            con.Open();
            string Query = "select *from SubjectTbl";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGrid_SubjectList.DataSource = dataSet.Tables[0];
            con.Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_SubjectName.Text=="")
            {
                MessageBox.Show("Missing Infoemation");
            }
            else
            {
                try
                {
                   
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SubjectTbl  (SubjName) values(@subName)", con);
                    cmd.Parameters.AddWithValue("@subName", txt_SubjectName.Text);
                 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Saved");

                    con.Close();
                    Reset();
                    DisplayAllSubject();
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

        private void dataGrid_SubjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGrid_StudentList.ColumnCount = 10;
            txt_SubjectName.Text = (dataGrid_SubjectList.SelectedRows[0].Cells[1].Value).ToString();
         

            if (txt_SubjectName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGrid_SubjectList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_SubjectName.Text == "" )
            {
                MessageBox.Show("Missing Infoemation");
            }
            else
            {
                try
                {
                    int Score = 0;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update SubjectTbl set SubjName=@suName where SubjId=@Subkey", con);
                    cmd.Parameters.AddWithValue("@suName", txt_SubjectName.Text);
                   
                    cmd.Parameters.AddWithValue("@Subkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stubject Updated");

                    con.Close();
                    Reset();
                    DisplayAllSubject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void lab_Student_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();

        }

        private void pic_Educating_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }

        private void pic_reporting_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void lab_Question_Click(object sender, EventArgs e)
        {
            Questions students = new Questions();
            students.Show();
            this.Hide();
        }

        private void lab_Subject_Click(object sender, EventArgs e)
        {
            Subjects students = new Subjects();
            students.Show();
            this.Hide();
        }
    }
}
