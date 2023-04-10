using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Exam_System
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayAllStudent();
            dataGrid_StudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void Reset()
        {
            txt_Name.Text = "";
            txt_Age.Text = "";
            txt_Address.Text = "";
            txt_Password.Text = "";
            txt_Phone.Text = "";
           

        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Exam;Integrated Security=true");
        public void DisplayAllStudent()
        {
            con.Open();
            string Query = "select *from StudentTbl";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGrid_StudentList.DataSource = dataSet.Tables[0];
            con.Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" || txt_Age.Text == "" || txt_Address.Text == "" || txt_Password.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Missing Infoemation");
            }
            else
            {
                try
                {
                    int Score = 0;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl  (StudName,StudAge,StudPass,StudScore,StudAdd,StudPhone) values(@stName,@stAge,@stPass,@stusScor,@stAdd,@stPho)", con);
                    cmd.Parameters.AddWithValue("@stName", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@stAge", txt_Age.Text);
                    cmd.Parameters.AddWithValue("@stPass", txt_Password.Text);
                    cmd.Parameters.AddWithValue("@stusScor", Score);
                    cmd.Parameters.AddWithValue("@stAdd", txt_Address.Text);
                    cmd.Parameters.AddWithValue("@stPho", txt_Phone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Saved");

                    con.Close();
                    Reset();
                    DisplayAllStudent();
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" || txt_Age.Text == "" || txt_Age.Text == "Age" || txt_Address.Text == "" || txt_Password.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Missing Infoemation");
            }
            else
            {
                try
                {
                    int Score = 0;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update StudentTbl set StudName=@stName,StudAge=@stAge,StudPass=@stPass,StudAdd=@stAdd,StudPhone=@stPho where StudId=@Stkey", con);
                    cmd.Parameters.AddWithValue("@stName", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@stAge", txt_Age.Text);
                    cmd.Parameters.AddWithValue("@stPass", txt_Password.Text);

                    cmd.Parameters.AddWithValue("@stAdd", txt_Address.Text);
                    cmd.Parameters.AddWithValue("@stPho", txt_Phone.Text);
                    cmd.Parameters.AddWithValue("@Stkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");

                    con.Close();
                    Reset();
                    DisplayAllStudent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        int Key = 0;
        private void dataGrid_StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGrid_StudentList.ColumnCount = 10;
            txt_Name.Text = (dataGrid_StudentList.SelectedRows[0].Cells[1].Value).ToString();
            txt_Age.Text = dataGrid_StudentList.SelectedRows[0].Cells[2].Value.ToString();
            txt_Password.Text = dataGrid_StudentList.SelectedRows[0].Cells[3].Value.ToString();
            txt_Address.Text = dataGrid_StudentList.SelectedRows[0].Cells[5].Value.ToString();
            txt_Phone.Text = dataGrid_StudentList.SelectedRows[0].Cells[6].Value.ToString();

            if (txt_Name.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGrid_StudentList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        //Sublect Label 
        private void label2_Click(object sender, EventArgs e)
        {
            Subjects students = new Subjects();
            students.Show();
            this.Hide();
        }

        private void pic_programming_Click(object sender, EventArgs e)
        {
            Subjects students = new Subjects();
            students.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }
    }
}