using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class Commit
    {
        [JsonPropertyName("sha")]
        public string sha { get; set; }
        [JsonPropertyName("node_id")]
        public string node_id { get; set; }
        [JsonPropertyName("commit")]
        public SmallCommit commit { get; set; }
        [JsonPropertyName("url")]
        public string url { get; set; }
        [JsonPropertyName("html_url")]
        public string html_url { get; set; }
        [JsonPropertyName("comments_url")]
        public string comments_url { get; set; }
        [JsonPropertyName("author")]
        public Author author { get; set; }
        [JsonPropertyName("commiter")]
        public Commiter commiter { get; set; }
        [JsonPropertyName("parents")]
        public List<Parents> parents { get; set; }
    }
}
