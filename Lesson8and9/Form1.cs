using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SchoolContext ctx = new SchoolContext();
            Student std = new Student();
            std.StudentName = "Bill";
            ctx.Students.Add(std);
            ctx.SaveChanges();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
