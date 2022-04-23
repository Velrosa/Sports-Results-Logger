using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sports_Results_Logger
{
    public static class EmailLogger
    {
        private static string filePath = @"D:\Users\steez\source\repos\Sports Results Logger\Sports Results Logger\EmailLog.txt";
        public static bool CheckEmailLogExists()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText("EmailLog.txt", "");
                Console.WriteLine("EmailLog.txt has been created.");
            }
            
            string text = File.ReadAllText(filePath);

            if (string.IsNullOrEmpty(text))
            {
                string time = DateTime.Now.ToString();
                File.WriteAllText("EmailLog.txt", time);
                return true;
            }
            return false;
        }

        public static bool CheckEmailTimeToSend()
        {
            string text = File.ReadAllText(filePath);

            DateTime sendTime = DateTime.Parse(text).AddDays(1);

            if(sendTime < DateTime.Now)
            {
                string time = DateTime.Now.ToString();
                File.WriteAllText("EmailLog.txt", time);
                return true;
            }
            return false;
        }
    }
}
