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
            int e = 0;
            //list = program.GetAwesome("vinta", "awesome-python");
            //foreach (string i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //str = program.GetRepoInfo("bbangert", "beaker");
            //Console.WriteLine("\nRepoinfo: " + str);
            //str = program.GetReadme("bbangert", "beaker", "master", "rst");
            //Console.WriteLine("\nReadMe:\n" + str);
            //str = Program.GetCommits("bbangert", "beaker");
            //Console.WriteLine("\nCommits:\n" + str);
            list = Program.GetAwesomeRepoUrl("vinta", "awesome-python");
            foreach (string i in list)
            {

                Console.WriteLine($"[{e}] {i}");
                e++;
            }
            int index = Convert.ToInt32(Console.ReadLine());
            str = program.GetRepo("vinta", "awesome-python",index);
            Console.WriteLine("\nRepos:\n" + str);
        }
        public List<string> GetAwesome(string userName,string repoName)
        { 
            string str = "";
            char search;
            int count = 1;
            List<string> repos = new List<string>();
            string url = $"https://raw.githubusercontent.com/{userName}/{repoName}/master/README.md";
            string repoResponse = Program.GetResponse(url);
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
        public static List<string> GetAwesomeRepoUrl(string userName1, string repoName1)
        {
            string str = "";
            char search;
            bool check;
            int count=0;
            List<string> urlrepos = new List<string>();
            string url = $"https://raw.githubusercontent.com/{userName1}/{repoName1}/master/README.md";
            string repoResponse = Program.GetResponse(url);
            Regex regex = new Regex(@"https://github.com(\w*)");
            MatchCollection matches = regex.Matches(repoResponse);
            foreach (Match match in matches)
            {
                check = false;
                search = '/';
                for (int i = 19; repoResponse[match.Index + i] != search; i++)
                {
                    str += repoResponse[match.Index + i].ToString();
                    count = i;
                }
                str = str.Replace("\n", "").Replace("\r", "");
                string userName = str;
                str = "";
                search = ')';
                for (int i=count+2 ; (repoResponse[match.Index + i] != search) && (repoResponse[match.Index + i] != '#' ) && (repoResponse[match.Index + i] != '/') && (repoResponse.Length > match.Index + i); i++)
                {
                    str += (repoResponse[match.Index + i].ToString());
                }
                str = str.Replace("\n", "").Replace("\r", "");
                string repoName = str;
                str = "";
                for (int i = 0; i < userName.Length; i++)
                {
                    if (userName[i] == ')')
                        check = true;
                }
                if (check == false)
                    urlrepos.Add($"https://api.github.com/repos/{userName}/{repoName}");
               
                 
            }
            return urlrepos;
        }
        public string GetRepoInfo(string userName,string repoName)
        {
            string url = $"https://api.github.com/repos/{userName}/{repoName}";
            RepoResponse repoResponse = JsonConvert.DeserializeObject<RepoResponse>(Program.GetResponse(url));
            return repoResponse.stargazers_count.ToString();
        }
        public string GetReadme(string userName, string repoName,string branchName,string readmeFormat)
        {
            string url = $"https://raw.githubusercontent.com/{userName}/{repoName}/{branchName}/README.{readmeFormat}";

            return Program.GetResponse(url);
        }
        public static string GetCommits(string userName, string repoName)
        {
            var url = $"https://api.github.com/repos/{userName}/{repoName}/commits";
            //https://api.github.com/repos/bbangert/beaker/commits
            List<Commit> commitCollection = JsonConvert.DeserializeObject<List<Commit>> (Program.GetResponse(url));
            return commitCollection[19].commit.author.date.ToString();
        }
        public static List<Commit> GetCommits(string url)
        {
            List<Commit> commitCollection = JsonConvert.DeserializeObject<List<Commit>>(Program.GetResponse(url));
            return commitCollection;
        }
        public string GetRepo(string userName, string repoName, int index)
        {
            string url="";
            //https://api.github.com/users/vinta/repos
            List<Repository> repositoriesCollection=new List<Repository>();
            repositoriesCollection.Add(JsonConvert.DeserializeObject<Repository>(Program.GetResponse(Program.GetAwesomeRepoUrl(userName, repoName)[index])));
            string SRepo="";
            foreach (Repository n in repositoriesCollection)
            {
                url = n.commits_url.Replace("{/sha}", "");
                List<DateTime> commitsDate = new List<DateTime>();
                foreach (Commit c in Program.GetCommits(url))
                {
                    commitsDate.Add(c.commit.author.date);
                }
                commitsDate.Sort();
                commitsDate.Reverse();
                SRepo += $"Имя репозитория: {n.name},кол-во звёзд: {n.stargazers_count},последний коммит: {commitsDate[0]} \n";
            }
            return SRepo;
        }
        public static string GetResponse(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            WebHeaderCollection webHeaderCollection = httpWebRequest.Headers;
            webHeaderCollection.Add("Authorization", "token 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");
            webHeaderCollection.Add("User-Agent", "Unbel1evab7e");
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            return response;
        }
    }
    
}
