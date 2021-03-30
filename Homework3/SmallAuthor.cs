using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class SmallAuthor
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("email")]
        public string email { get; set; }
        [JsonPropertyName("date")]
        public DateTime date { get; set; }
    }
}
