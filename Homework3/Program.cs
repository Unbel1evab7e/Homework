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
            string url = "https://api.github.com/users/vinta/repos";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            RepoResponse repoResponse = JsonConvert.DeserializeObject<RepoResponse>(response);
            Console.WriteLine("Temprature in {0}:{1} C", repoResponse);
            Console.ReadLine();
        }
    }
}
