using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PagerDutyInterview.ApiResponses
{
    public class LogEntriesResponse
    {
        [JsonPropertyName("log_entries")]
        public List<DataClasses.LogEntry> Entries { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("more")]
        public bool More { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }


    }



}
