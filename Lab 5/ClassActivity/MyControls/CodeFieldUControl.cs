using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControls
{
    public partial class CodeFieldUControl : UserControl
    {
        public CodeFieldUControl()
        {
            InitializeComponent();
        }

        public string CaptionText
        {
            get { return lblFieldName.Text; }
            set { lblFieldName.Text = value; }
        }

        private void txtCustCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                //0_9
                e.Handled = false;
            }
            else if (e.KeyChar >= 65 && e.KeyChar <= 90)
            {
                //A_Z
                e.Handled = false;

            }
            else if (e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                //a_z
                e.Handled = false;
            }
            else if (e.KeyChar == 8 || e.KeyChar == 13)
            {
                //a_z
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
