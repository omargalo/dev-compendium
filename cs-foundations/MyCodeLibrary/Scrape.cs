using System.IO;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetUrl(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetUrl(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        //Helper private method to encapsulate the functionallity
        //of getting the webpage itself
        private string GetUrl(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "That's All Folks";
            return content;
        }
    }
}