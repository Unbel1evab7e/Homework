using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class License
    {
        [JsonPropertyName("key")]
        public string key { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("spdx_id")]
        public string spdx_id { get; set; }
        [JsonPropertyName("url")]
        public string url { get; set; }
        [JsonPropertyName("node_id")]
        public string node_id { get; set; }
    }
}
