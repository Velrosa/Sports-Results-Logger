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
        public static bool CheckEmailLogExists()
        {
            string text = File.ReadAllText(@"D:\Users\steez\source\repos\Sports Results Logger\Sports Results Logger\WriteLines.txt");

            if (string.IsNullOrEmpty(text))
            {
                string time = DateTime.Now.ToString();
                File.WriteAllTextAsync("WriteLines.txt", time);
                return true;
            }
            return false;
        }

        public static bool CheckEmailTimeToSend()
        {
            string text = File.ReadAllText(@"D:\Users\steez\source\repos\Sports Results Logger\Sports Results Logger\WriteLines.txt");

            DateTime sendTime = DateTime.Parse(text).AddDays(1);

            if(sendTime < DateTime.Now)
            {
                string time = DateTime.Now.ToString();
                File.WriteAllTextAsync("WriteLines.txt", time);
                return true;
            }
            return false;
        }
    }
}
