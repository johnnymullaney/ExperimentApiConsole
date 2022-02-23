using Newtonsoft.Json;

namespace ExperimentApiConsole.Models
{
    public class Variation
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentage_included")]
        public string PercentageIncluded { get; set; }
    }
}
