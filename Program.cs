using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using PagerDutyInterview.ApiResponses;
using PagerDutyInterview.DataClasses;

namespace PagerDutyInterview

{
    class Program
    {
        private static readonly HttpClient client = new();

        static async Task Main()
        {
            SetupHttpClient();
            //await RetrieveAbilities();
            await RetrieveLogEntries();
        }

        private static async Task RetrieveAbilities()
        {
            
            var streamTask = client.GetStreamAsync("https://api.pagerduty.com/abilities");
            var response = await JsonSerializer.DeserializeAsync<AbilitiesResponse>(await streamTask);

            foreach (string ability in response.Abilities)
            {
                Console.WriteLine(ability);
            }
        }

        private static async Task RetrieveLogEntries()
        {
            var streamTask = client.GetStreamAsync("https://api.pagerduty.com/log_entries?include%5B%5D=incidents");
            var response = await JsonSerializer.DeserializeAsync<LogEntriesResponse>(await streamTask);

            foreach (LogEntry logEntry in response.Entries)
            {
                Console.WriteLine($"Id {logEntry.Id}: {logEntry.Summary}");
            }
        }

        private static void SetupHttpClient()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", "PagerDutyInterview Hi Mom");
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.pagerduty+json;version=2");
            client.DefaultRequestHeaders.Add("Authorization", "Token token=y_NbAkKc66ryYTWUXYEu");
            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
        }
    }
}
