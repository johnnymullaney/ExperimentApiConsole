using Newtonsoft.Json;

namespace ExperimentApiConsole.Models
{
    public class Metric
    {
        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("aggregator")]
        public string Aggregator { get; set; }

        [JsonProperty("winning_direction")]
        public string WinningDirection { get; set; }

        [JsonProperty("display_title")]
        public string DisplayTitle { get; set; }
    }
}
