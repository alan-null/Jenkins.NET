using Newtonsoft.Json;

namespace Jenkins.Net.Models.Builds
{
    public class Cause
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

    }
}