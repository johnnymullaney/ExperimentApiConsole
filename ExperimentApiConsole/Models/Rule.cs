using Newtonsoft.Json;

namespace ExperimentApiConsole.Models
{
    public class Rule
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("variations")]
        public Dictionary<string, Variation> Variations { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("percentage_included")]
        public string PercentageIncluded { get; set; }

        [JsonProperty("metrics")]
        public List<Metric> Metrics { get; set; }
    }
}
