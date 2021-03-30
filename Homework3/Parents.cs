using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class Parents
    {
        [JsonPropertyName("sha")]
        public string sha { get; set; }
        [JsonPropertyName("url")]
        public string url { get; set; }
        [JsonPropertyName("html_url")]
        public string html_url { get; set; }
    }
}
