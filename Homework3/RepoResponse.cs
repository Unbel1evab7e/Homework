using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class RepoResponse
    {
       [JsonIgnore()]
        public string Text { get; set; }

    }
}
