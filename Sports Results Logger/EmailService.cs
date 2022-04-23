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
            string log = EmailLogger.GetEmailLog();

            if (string.IsNullOrEmpty(log))
            {
                GetContentSendEmail(DateTime.Now);
                EmailLogger.SaveEmailLog(DateTime.Now.ToString());
                return;
            }

            DateTime sendTime = DateTime.Parse(log).AddDays(1);

            if (sendTime < DateTime.Now)
            {
                GetContentSendEmail(sendTime);
                EmailLogger.SaveEmailLog(sendTime.ToString());
                return;
            }
        }

        internal static void GetContentSendEmail(DateTime sendTime)
        {
            string content = HTMLScraper.GetContent(sendTime);
            string time = DateTime.Now.ToString();

            if(String.IsNullOrWhiteSpace(content)) return;

            MailSender.SendEmail($"NBA : Conference Standings ({sendTime})", content);

            Console.WriteLine($"Email has been sent.");
        }
    }
}
