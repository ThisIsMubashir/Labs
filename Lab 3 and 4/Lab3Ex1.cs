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
using System.Configuration;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        //Part b
        //SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            //Connect as windows authentication (not work for remote servers)
            //con = new SqlConnection("server=localhost;initial catalog=NORTHWND; integrated security=SSPI");
            //Check App.config file (Do add system.configuration as reference as well)
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*//Part b
                string command = "Delete from SHIPPERS where CompanyName='5';";
                cmd = new SqlCommand(command,con);*/
                con.Open();
                // Part b
                //cmd.BeginExecuteNonQuery();
                MessageBox.Show("Connection Open");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
