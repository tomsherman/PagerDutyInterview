using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PagerDutyInterview.ApiResponses
{

/*
 * {
 * users: []
 *       "id": "PAM4FGS",
      "type": "user",
      "summary": "Kyler Kuhn",
      "self": "https://api.pagerduty.com/users/PAM4FGS",
      "html_url": "https://subdomain.pagerduty.com/users/PAM4FGS",
      "name": "Kyler Kuhn",
      "email": "126_dvm_kyler_kuhn@beahan.name",
      "time_zone": "Asia/Hong_Kong",
      "color": "red",
      "role": "admin",
      "avatar_url": "https://secure.gravatar.com/avatar/47857d059adacf9a41dc4030c2e14b0a.png?d=mm&r=PG",
      "description": "Actually, I am the boss",
      "invitation_sent": false,
      "contact_methods": [
        {
          "id": "PVMGSML",
          "type": "email_contact_method_reference",
          "summary": "Work",
          "self": "https://api.pagerduty.com/users/PAM4FGS/contact_methods/PVMGSMLL"
        }
      ],
      "notification_rules": [
        {
          "id": "P8GRWKK",
          "type": "assignment_notification_rule_reference",
          "summary": "Default",
          "self": "https://api.pagerduty.com/users/PXPGF42/notification_rules/P8GRWKK",
          "html_url": null
        }
      ],
      "job_title": "Senior Engineer",
      "teams": [
        {
          "id": "PQ9K7I8",
          "type": "team_reference",
          "summary": "Engineering",
          "self": "https://api.pagerduty.com/teams/PQ9K7I8",
          "html_url": "https://subdomain.pagerduty.com/teams/PQ9K7I8"
        }
      ]
    }
  ],
  "limit": 25,
  "offset": 0,
  "more": false,
  "total": null
*/

    class UsersResponse
    {
        [JsonPropertyName("users")]
        public List<DataClasses.User> Users { get; set; }

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
