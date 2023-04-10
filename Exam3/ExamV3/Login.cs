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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            GetSubjects();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Exam;Integrated Security=true");
        public static string StudName = "";
        public static string SubjName = "";
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
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(*) from StudentTbl where StudPass='"+txt_Password.Text+ "'and StudName='"+txt_UserName.Text+"'", con);
                DataTable dt=new DataTable();
                sqlDataAdapter.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    StudName = txt_UserName.Text;
                    SubjName = com_Subject.SelectedValue.ToString();
                    //Exam Form
                    Questions examsobj = new Questions();
                    examsobj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Student Name Or Password");
                }
                con.Close();
            }
        }
    }
}
