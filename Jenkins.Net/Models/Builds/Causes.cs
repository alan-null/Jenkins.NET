using Newtonsoft.Json;

namespace Jenkins.Net.Models.Builds
{
    public class Causes
    {
        [JsonProperty("causes")]
        public Cause[] Cause { get; set; }
    }
}