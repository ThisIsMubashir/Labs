using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void State_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("You have selected {0} with ID {1}", userControl11.selectstate.name, userControl11.selectstate.ID));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
