using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {

        Video myvid = new Video();
        VideoEncoder vde = new VideoEncoder();//Publisher-source
        MailService mymail = new MailService();//Consumer- subscriber
        TextMsgService mytxt = new TextMsgService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myvid.Title = "My First Video";
            
            vde.VideoEncoded += mymail.OnVideoEncoded;
            vde.VideoEncoded += mytxt.OnVideoEncoded;


                
            vde.Encode(myvid);
        }
    }
}
