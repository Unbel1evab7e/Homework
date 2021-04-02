using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class Owner
    {
        [JsonPropertyName("login")]
        public string login { get; set; }
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("node_id")]
        public string node_id { get; set; }
        [JsonPropertyName("avatar_url")]
        public string avatar_url { get; set; }
        [JsonPropertyName("gravatar_id")]
        public string gravatar_id { get; set; }
        [JsonPropertyName("url")]
        public string url { get; set; }
        [JsonPropertyName("html_url")]
        public string html_url { get; set; }
        [JsonPropertyName("followers_url")]
        public string followers_url { get; set; }
         [JsonPropertyName("following_url")]
        public string following_url { get; set; }
        [JsonPropertyName("gists_url")]
        public string gists_url { get; set; }
        [JsonPropertyName("starred_url")]
        public string starred_url { get; set; }
        [JsonPropertyName("subscriptions_url")]
        public string subscriptions_url { get; set; }
        [JsonPropertyName("organizations_url")]
        public string organizations_url { get; set; }
        [JsonPropertyName("repos_url")]
        public string repos_url { get; set; }
        [JsonPropertyName("events_url")]
        public string events_url { get; set; }
        [JsonPropertyName("received_events_url")]
        public string received_events_url { get; set; }
        [JsonPropertyName("type")]
        public string type { get; set; }
        [JsonPropertyName("site_admin")]
        public bool site_admin { get; set; }
    }
}
