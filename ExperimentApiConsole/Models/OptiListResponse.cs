using Newtonsoft.Json;

namespace ExperimentApiConsole.Models
{
    public class OptiListResponse<T> where T : class
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public List<T> Items { get; set; }
    }
}
