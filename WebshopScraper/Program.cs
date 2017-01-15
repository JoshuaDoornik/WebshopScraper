using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopScraper.sadasd;

namespace WebshopScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var scraper = new GetHtml();
            scraper.Scrape("https://www.google.nl/");

            Console.ReadLine();
        }
    }
}
