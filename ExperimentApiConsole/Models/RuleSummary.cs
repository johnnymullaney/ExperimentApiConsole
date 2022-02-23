using Newtonsoft.Json;

namespace ExperimentApiConsole.Models
{
    public class RuleSummary
    {
        [JsonProperty("keys")]
        public string[] Keys { get; set; }
    }
}
