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
        public static string GetContent()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.basketball-reference.com/boxscores/");

            var description = document.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[4]").First().InnerHtml;
            return description;
        }
    }
}
