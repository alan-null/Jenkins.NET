using Newtonsoft.Json;

namespace Jenkins.Net.Models
{
    public class Page : INavigable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
