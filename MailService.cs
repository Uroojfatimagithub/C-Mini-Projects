using System;

namespace Events_and_Delegates
{
    public class MailService
    {
        //this method in the mailservice is the handler
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            //now in this case we are not going to send actual mail we just need to simulate that
            Console.WriteLine("Mail Service: Sending an Email...."+ e.Video.Title);
        }
    }
}
