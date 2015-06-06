using Jenkins.Net.Models.Summary;
using Newtonsoft.Json;

namespace Jenkins.Net.Models
{
    public class View : Page
    {
        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("jobs")]
        public JobLink[] JobsLink { get; set; }

        [JsonProperty("property")]
        public object Property { get; set; }
    }
}
