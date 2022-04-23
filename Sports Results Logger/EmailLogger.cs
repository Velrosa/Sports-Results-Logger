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
        public static string GetEmailLog()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText("EmailLog.txt", "");
                Console.WriteLine("EmailLog.txt has been created.");
            }
            
            return File.ReadAllText(filePath);
        }

        public static void SaveEmailLog(string time)
        {
            File.WriteAllText("EmailLog.txt", time);
        }
    }
}
