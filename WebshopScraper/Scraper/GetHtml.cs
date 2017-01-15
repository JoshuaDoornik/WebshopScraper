using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopScraper.Scraper;

namespace WebshopScraper.sadasd
{
    class GetHtml
    {
       private HtmlWeb web;


        public GetHtml()
        {
            web = new HtmlWeb();

        }

        public Page Scrape(String Url) {


            HtmlDocument doc = web.Load(Url);

            Console.WriteLine(doc);
            return null;
        }
    }
}
