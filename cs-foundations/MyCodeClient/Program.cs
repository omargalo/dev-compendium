using MyCodeLibrary;
using System;

namespace MyCodeClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}