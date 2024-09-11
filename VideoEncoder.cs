using System;
using System.Threading;

namespace Events_and_Delegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
        public class VideoEncoder
        {
            //Define a delegate ? means publisher or subscriber k beech ek trah ka contract hota yeh
            //Define an event based on that delegate
            //Publish or raise an event

            //lets define a delegate means implemeting the above steps
            //sab sy pehly publis key word ta k wo khen bhi accessible ho phir delegate key word phir jis trah ek method
            //bnaaty same wesy hi like return typr method name yeh ek event handler hoga
            //the first parameter of an event handler is to be the object and the second parmeter is event args which is for when we want to send any additional data with the event

            //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);


            //EventHandler in Generic Form
            //EventHandler<TEventArgs>
            //we are going to define an event called video encoded means we have used past tense means event khatam ho jay
            //Define an event based on that delegate
            public event EventHandler<VideoEventArgs> VideoEncoded;
            //public event EventHandler VideoEncoding;
            //to raise an event we need a method responsible for that
            public void Encode(Video video)
            {
                Console.WriteLine("Encoding video....");
                Thread.Sleep(3000);
                OnVideoEncoded(video);    //and we will assuming that this method will notify all the subscribers
                                          //so how do we notify the subscribers that is the responsibility of this method go o protected
            }
            //.NET framework suggest that your event publisher methods should be protected
            //they should be virtual and void and interms of naming ther=y should start with word On and the name if the en=vent which is VIdeoEncoded
            //now in encode method when an encoding is finished we just need to call an encode method
            protected virtual void OnVideoEncoded(Video video)
            {
                if (VideoEncoded != null)
                {
                    VideoEncoded(this, new VideoEventArgs() { Video = video });
                    //now lets go to program.cs and create a couple of subscribers first go and create class Mailservice now this class is responsible for sending an email once the video is encoded
                }
            }
        }
    }
}
