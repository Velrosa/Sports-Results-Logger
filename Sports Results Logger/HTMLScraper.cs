using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Sports_Results_Logger
{
    public static class HTMLScraper
    {
        public static string GetContent(DateTime sendTime)
        {
            HtmlWeb web = new HtmlWeb();

            string dateToFetch = sendTime.ToShortDateString();
            string[] dateInfo = dateToFetch.Split('/');

            HtmlDocument document = web.Load($"https://www.basketball-reference.com/boxscores/?month={dateInfo[1]}&day={dateInfo[0]}&year={dateInfo[2]}");

            var description = document.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[3]").First().InnerHtml;
            return description;
        }
    }
}
