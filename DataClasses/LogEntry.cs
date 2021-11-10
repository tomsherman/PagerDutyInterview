using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PagerDutyInterview.DataClasses
{
    public class LogEntry
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    }
}
