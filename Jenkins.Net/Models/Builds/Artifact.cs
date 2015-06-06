using Newtonsoft.Json;

namespace Jenkins.Net.Models.Builds
{
    public class Artifact
    {
        [JsonProperty("displayPath")]
        public string DisplayPath { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("relativePath")]
        public string RelativePath { get; set; }
    }
}
