using Newtonsoft.Json;

namespace Jenkins.Net.Models.Builds
{
    public class Culprit
    {
        [JsonProperty("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }
}