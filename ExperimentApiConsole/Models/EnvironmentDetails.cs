using Newtonsoft.Json;

namespace ExperimentApiConsole.Models
{
    public class EnvironmentDetails
    {
        public EnvironmentDetails()
        {
            RulesSummary = new Dictionary<string, RuleSummary>();
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("`key")]
        public string Key { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("rules_summary")]
        public Dictionary<string, RuleSummary> RulesSummary { get; set; }
    }
}
