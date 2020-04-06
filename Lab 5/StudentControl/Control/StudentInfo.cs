using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControlsLibrary
{
    public partial class StudentInfo : UserControl
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        public StudentModel GetStudentDetails()
        {
            StudentModel model = new StudentModel();

            model.Name = txtName.Text;
            model.City = txtCity.Text;
            model.Other = txtDetails.Text;
            model.IsMale = rbMale.Checked ? true : false;

            return model;

        }
    }
}
