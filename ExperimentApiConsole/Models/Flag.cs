using Newtonsoft.Json;

namespace ExperimentApiConsole.Models
{
    public class Flag
    {
        public Flag()
        {
            Environments = new Dictionary<string, EnvironmentDetails>();
        }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("environments")]
        public Dictionary<string, EnvironmentDetails> Environments { get; set; }

        [JsonProperty("project_id")]
        public ulong ProjectId { get; set; }

        //[JsonProperty("variable_definitions")]
        //public List<Variable> Variables { get; set; }
    }
}
