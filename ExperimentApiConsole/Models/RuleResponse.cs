using Newtonsoft.Json;

namespace ExperimentApiConsole.Models
{
    public class RuleResponse
    {
        [JsonProperty("flag_key")]
        public string FlagKey { get; set; }

        [JsonProperty("environment_key")]
        public string EnvironmentKey { get; set; }

        [JsonProperty("environment_name")]
        public string EnvironmentName { get; set; }

        [JsonProperty("default_variation_key")]
        public string DefaultVariationKey { get; set; }

        [JsonProperty("default_variation_name")]
        public string DefaultVariationName { get; set; }

        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("rules")]
        public Dictionary<string, Rule> Rules { get; set; }
    }
}
