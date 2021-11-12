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
            //await RetrieveLogEntries();
            await RetrieverUsers(0);
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

        private static async Task RetrieverUsers(int offset)
        {
            // todo real pagination stuff
            var streamTask = client.GetStreamAsync(@"https://api.pagerduty.com/users?include%5B%5D=contact_methods&total=true&limit=99999");
            var response = await JsonSerializer.DeserializeAsync<UsersResponse>(await streamTask);

            var menu = 1;
            foreach (DataClasses.User user in response.Users)
            {
                Console.WriteLine($"{menu}: {user.Name} {user.Email}");
                menu += 1;
            }

            Console.WriteLine();
            Console.Write("Enter number for contact lookup: ");
            var selectionText = Console.ReadLine();
            var selection = int.Parse(selectionText);
            if (selection < 1 || selection > response.Users.Count)
            {
                throw new ArgumentOutOfRangeException("nope");
            }

            var selectedUser = response.Users[selection - 1];
            Console.WriteLine($"Details for {selectedUser.Name}:");
            foreach (DataClasses.User.ContactMethod contactMethod in selectedUser.ContactMethods)
            {
                Console.WriteLine($"  {contactMethod.Type}: {contactMethod.Address}");
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
