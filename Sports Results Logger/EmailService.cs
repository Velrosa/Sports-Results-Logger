using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Results_Logger
{
    internal class EmailService
    {        
        public static void SendEmailProcess()
        {
            if (EmailLogger.CheckEmailLogExists() || EmailLogger.CheckEmailTimeToSend())
            {
                GetContentSendEmail();
            }
        }

        internal static void GetContentSendEmail()
        {
            string content = HTMLScraper.GetContent();
            string time = DateTime.Now.ToString();
            
            MailSender.SendEmail($"NBA : Conference Standings ({time})", content);

            Console.WriteLine($"Email has been sent at {time}");
        }
    }
}
