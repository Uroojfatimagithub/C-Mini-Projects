using System;

namespace Events_and_Delegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending a text message..." + args.Video.Title);
        }
    }
}
