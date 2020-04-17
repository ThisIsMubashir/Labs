using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Events
{
    class VideoEventArgs : EventArgs {
        public Video video { get; set; }
    }

    class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event based on delegate
        // 3. Raise an event

        // 1. Define a delegate 
        //public delegate void VideoEncodedEvenHandler(object source, EventArgs args);
        //public delegate void VideoEncodedEvenHandler(object source, VideoEventArgs args);

        //2. Define an event 
        //public event VideoEncodedEvenHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
        

        public void Encode(Video myvid) {
            MessageBox.Show("Encoding in Progress..");
            Thread.Sleep(3000);

            //mailservice.Onvideoencoded()
            //textmsg.Onvideoencoded()

            //OnVideEncoded();
            OnVideEncoded(myvid);
        }

        //3. Raise and event
        protected virtual void OnVideEncoded(Video myvid)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { video = myvid });
                //VideoEncoded(this, EventArgs.Empty);
        }

    }
}
