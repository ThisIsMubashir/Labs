using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson12Task1
{
    public partial class StudentDb : Form
    {
        private void ViewUpdate() {
            StudentDbEntities context = new StudentDbEntities();
            var qry = context.Students.ToList();
            dataGridView1.DataSource = qry;
        }

        public StudentDb()
        {
            InitializeComponent();
            ViewUpdate();
        }

        private void Reset()
        {
            tbStdID.Text = "";
            tbStdName.Text = "";
            tbStdAddress.Text = "";
            tbStdAge.Text = "";
            tbStdPhone.Text = "";
            tbStdGender.Text = "";

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentDbEntities context = new StudentDbEntities();
            Student std = new Student();
            std.StudentId = Int16.Parse(tbStdID.Text);
            std.Name = tbStdName.Text;
            std.Address = tbStdAddress.Text;
            std.Age = Int16.Parse(tbStdAge.Text);
            std.Gender = tbStdGender.Text;
            std.Phone = tbStdPhone.Text;

            context.Students.Add(std);
            context.SaveChanges();
            MessageBox.Show("Record is successfully inserted");
            ViewUpdate();
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(tbStdID.Text);
            StudentDbEntities context = new StudentDbEntities();
            Student std = context.Students.Where(x => x.StudentId == id).First();
            context.Students.Remove(std);
            context.SaveChanges();
            context.SaveChanges();
            MessageBox.Show("Successfully Deleted");
            ViewUpdate();
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(tbStdID.Text);
            StudentDbEntities context = new StudentDbEntities();
            Student std = context.Students.Where(x => x.StudentId == id).First();
            std.Name = tbStdName.Text;
            std.Address = tbStdAddress.Text;
            std.Age = Int16.Parse(tbStdAge.Text);
            std.Gender = tbStdGender.Text;
            std.Phone = tbStdPhone.Text;
            context.SaveChanges();
            MessageBox.Show("Update is successful");
            ViewUpdate();
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(tbStdID.Text);
            StudentDbEntities context = new StudentDbEntities();
            Student std = context.Students.Where(x => x.StudentId == id).First();

            tbStdID.Text = std.StudentId.ToString();
            tbStdName.Text = std.Name;
            tbStdAddress.Text = std.Address ;
            tbStdAge.Text = std.Age.ToString();
            tbStdGender.Text = std.Gender;
            tbStdPhone.Text = std.Phone;
            ViewUpdate();
            
        }
    }
}
