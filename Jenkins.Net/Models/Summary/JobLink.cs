using Newtonsoft.Json;

namespace Jenkins.Net.Models.Summary
{
    public class JobLink : Page
    {
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}