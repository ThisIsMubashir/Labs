using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageUser;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.AuthenticateUser(tb_UserName.Text, tb_password.Text))
                MessageBox.Show(user.HelloUser(tb_UserName.Text));
            else
                MessageBox.Show("Invalid Username / Password");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
