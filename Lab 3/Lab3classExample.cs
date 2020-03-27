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

namespace CURD
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        SqlDataAdapter da;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("server=localhost; initial catalog=StudentDb;integrated security=SSPI");
        }

        void Reset() {
            tbStudentAddress.Text = "";
            tbStudentName.Text = "";
            tbStudetnID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string command = "select max(StudentID)+1 from Student;";
            cmd = new SqlCommand(command, conn);
            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            tbStudetnID.Text = id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = tbStudetnID.Text;
            string name = tbStudentName.Text;
            string address = tbStudentAddress.Text;

            string command = string.Format("Insert into student values ({0},'{1}','{2}')",id,name,address);
            cmd = new SqlCommand(command, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Value is saved.");
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = tbStudetnID.Text;

            string command = "select * from student where studentid = " + id;
            cmd = new SqlCommand(command, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // REading the data
            if (dr.Read())
            {
                tbStudentName.Text = dr[1].ToString();
                tbStudentAddress.Text = dr["StudentAddress"].ToString();
            }
            else {
                Reset();
                MessageBox.Show("Not a valid student ID");
            }

            dr.Close();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = tbStudetnID.Text;
            string name = tbStudentName.Text;
            string address = tbStudentAddress.Text;

            string command = string.Format("update student set studentaddress = '{0}' where studentID ={1}", address,id);
            cmd = new SqlCommand(command, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("The value has been updated");
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tbStudetnID.Text;

            string command = "delete from student where studentid = " + id;
            cmd = new SqlCommand(command, conn);
            conn.Open();
            int test = (int)cmd.ExecuteNonQuery();
            conn.Close();

            if (test == 0)
            {
                MessageBox.Show("You have entered an invalid StudentID");
                Reset();
            }
            else { 
                MessageBox.Show("Record has been deleted for studentid "+ id);
                Reset();
            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string command = "Select * from city";
            
            da = new SqlDataAdapter(command,conn);
            ds = new DataSet();
            da.Fill(ds,"City");

            comboBox1.DataSource = ds.Tables["City"];
            comboBox1.DisplayMember = "City";
            comboBox1.ValueMember = "CityCode";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbZipcode.Text = comboBox1.SelectedValue.ToString();
        }



        
    }
}
