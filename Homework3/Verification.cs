using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class Verification
    {
        [JsonPropertyName("verified")]
        public bool verified { get; set; }
        [JsonPropertyName("reason")]
        public string reason { get; set; }
        [JsonPropertyName("signature")]
        public string signature { get; set; }
        [JsonPropertyName("payload")]
        public string payload { get; set; }
    }
}
