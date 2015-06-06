using Newtonsoft.Json;

namespace Jenkins.Net.Models.Jobs
{
    public class BuildLink : INavigable
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}