using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class Tree
    {
        [JsonPropertyName("sha")]
        public string sha { get; set; }
        [JsonPropertyName("url")]
        public string url { get; set; }
    }
}
