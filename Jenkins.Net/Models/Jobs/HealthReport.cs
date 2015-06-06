using Newtonsoft.Json;

namespace Jenkins.Net.Models.Jobs
{
    public class HealthReport
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iconClassName")]
        public string IconClassName { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }
}