using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://raw.githubusercontent.com/vinta/awesome-python/master/README.md";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            WebHeaderCollection webHeaderCollection = httpWebRequest.Headers;
            webHeaderCollection.Add("User-Agent","Unbel1evab7e");
            webHeaderCollection.Add("Authorization", "c9678ec17fa61749c162edd7f9f31875b0a5d495");
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            RepoResponse repoResponse = JsonConvert.DeserializeObject<RepoResponse>(response);
            Console.WriteLine(repoResponse.Text);
            Console.ReadLine();
        }
    }
}
