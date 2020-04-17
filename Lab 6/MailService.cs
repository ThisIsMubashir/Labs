using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    class MailService
    {
        //public void OnVideoEncoded(object source, EventArgs args)
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            MessageBox.Show("Mail has been sent " + args.video.Title );
        }
    }
}
