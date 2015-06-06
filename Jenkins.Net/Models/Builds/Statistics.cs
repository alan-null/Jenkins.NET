using Newtonsoft.Json;

namespace Jenkins.Net.Models.Builds
{
    public class Statistics
    {
        [JsonProperty("failCount")]
        public int FailCount { get; set; }

        [JsonProperty("skipCount")]
        public int SkipCount { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("urlName")]
        public string UrlName { get; set; }
    }
}