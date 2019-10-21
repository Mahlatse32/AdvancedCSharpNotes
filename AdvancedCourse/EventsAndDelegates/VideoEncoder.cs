using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video video { get; set; }
    }
    public class VideoEncoder
    {
        //1 - define a delegate
        //2 - define an event based on that delegate
        //3 - Raise an event

        public event EventHandler<VideoEventArgs> VideoEncoded; // event based on the delegate
        public void Encode(Video video)
        {
            Console.WriteLine("encoding video . . . ");
            Thread.Sleep(3000);

            OnVideoEncoded(video); //raise an event
        }

        protected virtual void OnVideoEncoded(Video video) //event publisher method
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { video = video});
        }
    }
}
