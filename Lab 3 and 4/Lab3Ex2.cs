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

namespace Lab3_CRUD
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        //Last section
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("server=localhost;initial catalog=Department_Lab3;integrated security=SSPI");
        }

        void Reset()
        {
            tbDeptID.Text = "";
            tbDeptName.Text = "";
            tbDeptLocation.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "select max(DeptID)+1 from Departments;";
            cmd = new SqlCommand(command, conn);
            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            //string id = cmd.ExecuteScalar().ToString();
            conn.Close();
            tbDeptID.Text = id.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = tbDeptID.Text;
            string name = tbDeptName.Text;
            string location = tbDeptLocation.Text;

            string command = string.Format("Insert into departments values ({0},'{1}',{2})", id, name, location);
            cmd = new SqlCommand(command, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = tbDeptID.Text;

            string command = "select * from departments where DeptID = " + id;
            cmd = new SqlCommand(command, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbDeptName.Text = dr[1].ToString();
                tbDeptLocation.Text = dr["Location"].ToString();
            }
            else {
                Reset();
                MessageBox.Show("Does not find the record");   
            }
            dr.Close();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = tbDeptID.Text;
            string name = tbDeptName.Text;
            string location = tbDeptLocation.Text;

            string command = string.Format("update departments set deptname = '{0}', location = {1} where deptid = {2};", name, location, id);
            cmd = new SqlCommand(command, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tbDeptID.Text;

            string command = "delete from departments where deptid ="+id;
            cmd = new SqlCommand(command, conn);
            conn.Open();
            int test = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (test == 0) {
                MessageBox.Show("No department with DeptID " + id + " Retry");
                Reset();
            }
            else{
                MessageBox.Show("Record Deleted " + test.ToString());
                Reset();
            }
            
        }

        private void CmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDeptLocation.Text = CmbLocation.SelectedValue.ToString();
        }

        private void CmbLocation_Click(object sender, EventArgs e)
        {
            string command = "select * from locations_1";

            da = new SqlDataAdapter(command, conn);
            ds = new DataSet();
            da.Fill(ds, "Locations_1");

            CmbLocation.DataSource = ds.Tables["Locations_1"];
            CmbLocation.DisplayMember = "City";
            CmbLocation.ValueMember = "LocID";
        }


 
    }
}
