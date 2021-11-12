using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PagerDutyInterview.DataClasses
{
    /*
     * {
  "users": [
    {
      "id": "PXPGF42",
      "type": "user",
      "summary": "Earline Greenholt",
      "self": "https://api.pagerduty.com/users/PXPGF42",
      "html_url": "https://subdomain.pagerduty.com/users/PXPGF42",
      "name": "Earline Greenholt",
      "email": "125.greenholt.earline@graham.name",
      "time_zone": "America/Lima",
      "color": "green",
      "role": "admin",
      "avatar_url": "https://secure.gravatar.com/avatar/a8b714a39626f2444ee05990b078995f.png?d=mm&r=PG",
      "description": "I'm the boss",
      "invitation_sent": false,
      "contact_methods": [
        {
          "id": "PTDVERC",
          "type": "email_contact_method_reference",
          "summary": "Default",
          "self": "https://api.pagerduty.com/users/PXPGF42/contact_methods/PTDVERC"
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
      "job_title": "Director of Engineering",
      "teams": [
        {
          "id": "PQ9K7I8",
          "type": "team_reference",
          "summary": "Engineering",
          "self": "https://api.pagerduty.com/teams/PQ9K7I8",
          "html_url": "https://subdomain.pagerduty.com/teams/PQ9K7I8"
        }
      ]
    },
    {
      "id": "PAM4FGS",
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
}
    */
    class User
    {
        //[JsonPropertyName("contact_methods")]
        //public List<DataClasses.ContactMethods> ContactMethods { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("contact_methods")]
        public List<ContactMethod> ContactMethods { get; set; }

        /*

              "contact_methods": [
        {
          "id": "PSMLP14",
          "type": "email_contact_method",
          "summary": "Default",
          "self": "https://api.pagerduty.com/users/PLOASXQ/contact_methods/PSMLP14",
          "html_url": null,
          "label": "Default",
          "address": "alan.shepard@nasa.example",
          "send_short_email": false,
          "send_html_email": true
        },
        {
          "id": "P3W47MP",
          "type": "phone_contact_method",
          "summary": "Work",
          "self": "https://api.pagerduty.com/users/PLOASXQ/contact_methods/P3W47MP",
          "html_url": null,
          "label": "Work",
          "address": "1115550001",
          "blacklisted": false,
          "country_code": 1
        },
        {
          "id": "PBXT65T",
          "type": "sms_contact_method",
          "summary": "Mobile",
          "self": "https://api.pagerduty.com/users/PLOASXQ/contact_methods/PBXT65T",
          "html_url": null,
          "label": "Mobile",
          "address": "1115550002",
          "blacklisted": false,
          "country_code": 1,
          "enabled": true
        }
      ],

        */
        public class ContactMethod
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("address")]
            public string Address { get; set; }
        }
    }
}
