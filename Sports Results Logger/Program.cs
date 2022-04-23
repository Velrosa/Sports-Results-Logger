using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTableExt;
using System.Text;
using Quartz;

namespace Sports_Results_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = HTMLScraper.GetContent();

            MailSender.SendEmail("NBA - Eastern Conference Standings", content);
        }
    }
}
