using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class SmallCommit
    {
        [JsonPropertyName("author")]
        public SmallAuthor author { get; set; }
        [JsonPropertyName("commiter")]
        public SmallCommiter commiter { get; set; }
        [JsonPropertyName("message")]
        public string message { get; set; }
        [JsonPropertyName("tree")]
        public Tree tree { get; set; }
        [JsonPropertyName("url")]
        public string url { get; set; }
        [JsonPropertyName("comment_count")]
        public int comment_count { get; set; }
        [JsonPropertyName("verification")]
        public Verification verification { get; set; }
    }
}
