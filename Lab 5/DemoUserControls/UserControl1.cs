using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUserControls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public Class1 selectstate {
            get {
                return (Class1)cmbStates.SelectedItem;
            }
        }
        private void state_load(object sender, EventArgs e)
        {
            List<Class1> list = new List<Class1>();
            list.Add(new Class1() { ID = 1, name = "Queensland" });
            list.Add(new Class1() { ID = 2, name = "New South Wales" });
            list.Add(new Class1() { ID = 3, name = "Northern Territory" });
            list.Add(new Class1() { ID = 4, name = "Western Australia" });
            cmbStates.DataSource = list;
            cmbStates.DisplayMember = "name";
            cmbStates.ValueMember = "ID";
        }
    }
}
