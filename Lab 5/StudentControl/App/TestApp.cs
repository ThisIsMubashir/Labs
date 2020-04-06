using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControlsLibrary;

namespace NewTestApp
{
    public partial class TestApp : Form
    {
        public TestApp()
        {
            InitializeComponent();
        }

        private void btnPrintUserDetails_Click(object sender, EventArgs e)
        {
            //Student info for button 1
            var data =studentInfo1.GetStudentDetails();

            DisplayStudentDetails(data,studentInfo1.Name);
        }

        private void DisplayStudentDetails(StudentModel data, string Name)
        {
            txtResponses.Text = " I am Student " + Name+Environment.NewLine;

            txtResponses.Text = data.Name + Environment.NewLine;
            txtResponses.Text += data.City + Environment.NewLine;
            txtResponses.Text += data.Other + Environment.NewLine;
            txtResponses.Text += data.IsMale ? "Male" : "Female" + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Student info for button 3
            var data = studentInfo2.GetStudentDetails();

            DisplayStudentDetails(data, studentInfo2.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Student info for button 2
            var data = studentInfo3.GetStudentDetails();

            DisplayStudentDetails(data, studentInfo2.Name);
        }
    }
}
