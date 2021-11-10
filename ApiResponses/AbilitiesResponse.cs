using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PagerDutyInterview.ApiResponses
{
    public class AbilitiesResponse
    {
        [JsonPropertyName("abilities")]
        public List<string> Abilities { get; set; }
    }

}
