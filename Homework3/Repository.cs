using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class Repository
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("node_id")]
        public string node_id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("full_name")]
        public string full_name { get; set; }
       
        [JsonPropertyName("owner")]
        public Owner owner { get; set; }
        
        [JsonPropertyName("commits_url")]
        public string commits_url { get; set; }
        
        [JsonPropertyName("stargazers_count")]
        public int stargazers_count { get; set; }

        public License license { get; set; }
        

    }
}
