using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            CommitCollection commitCollection = new CommitCollection();
            List<string> list = new List<string>();
            string str;
            list = program.GetAwesome("vinta", "awesome-python");
            foreach (string i in list)
                Console.WriteLine(i);
            str = program.GetRepoInfo("bbangert", "beaker");
            Console.WriteLine("\nRepoinfo: "+str);
            str = program.GetReadme("bbangert", "beaker", "master", "rst");
            Console.WriteLine("\nReadMe:\n" + str);
            str = program.GetCommits("bbangert", "beaker").ToString();
            Console.WriteLine("\nCommits:\n" + str);
        }
        public List<string> GetAwesome(string userName,string repoName)
        { 
            string str = "";
            char search;
            int count = 1;
            List<string> repos = new List<string>();
            string url = $"https://raw.githubusercontent.com/{userName}/{repoName}/master/README.md";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            WebHeaderCollection webHeaderCollection = httpWebRequest.Headers;
            webHeaderCollection.Add("User-Agent", "Unbel1evab7e");
            webHeaderCollection.Add("Authorization", "c9678ec17fa61749c162edd7f9f31875b0a5d495");
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            string repoResponse = response;
            Regex regex = new Regex(@"[#]");
            MatchCollection matches = regex.Matches(repoResponse);
            foreach (Match match in matches)
            {
                search = '\n';
                if (repoResponse[match.Index + 1] == '#')
                {
                    for (int i = 2; repoResponse[match.Index + i] != search; i++)
                    {
                        str += (repoResponse[match.Index + i].ToString());
                    }
                    str = str.Replace("\n", "").Replace("\r", "");
                    str = str + $" [{count}]";
                    repos.Add(str);
                    count++;
                    str = "";
                }
            }

            return repos;
        }
        public string GetRepoInfo(string userName,string repoName)
        {
            string url = $"https://api.github.com/repos/{userName}/{repoName}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            WebHeaderCollection webHeaderCollection = httpWebRequest.Headers;
            webHeaderCollection.Add("User-Agent", "Unbel1evab7e");
            webHeaderCollection.Add("Authorization", "c9678ec17fa61749c162edd7f9f31875b0a5d495");
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            RepoResponse repoResponse = JsonConvert.DeserializeObject<RepoResponse>(response);
            return repoResponse.stargazers_count.ToString();
        }
        public string GetReadme(string userName, string repoName,string branchName,string readmeFormat)
        {
            string url = $"https://raw.githubusercontent.com/{userName}/{repoName}/{branchName}/README.{readmeFormat}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            WebHeaderCollection webHeaderCollection = httpWebRequest.Headers;
            webHeaderCollection.Add("User-Agent", "Unbel1evab7e");
            webHeaderCollection.Add("Authorization", "c9678ec17fa61749c162edd7f9f31875b0a5d495");
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            return response;
        }
        public string GetCommits(string userName, string repoName)
        {
            
            var url = $"https://api.github.com/repos/{userName}/{repoName}/commits";
            //https://api.github.com/repos/bbangert/beaker/commits
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            WebHeaderCollection webHeaderCollection = httpWebRequest.Headers;
            webHeaderCollection.Add("User-Agent", "Unbel1evab7e");
            webHeaderCollection.Add("Authorization", "c9678ec17fa61749c162edd7f9f31875b0a5d495");
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            List<Commit> commitCollection = JsonConvert.DeserializeObject<List<Commit>> (response);
            return commitCollection[0].commit.author.date.ToString();

        }
    }
    
}
