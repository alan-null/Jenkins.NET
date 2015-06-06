using Newtonsoft.Json;

namespace Jenkins.Net.Models.Summary
{
    public class Dashboard
    {
        [JsonProperty("assignedLabels")]
        public object AssignedLabels { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("nodeDescription")]
        public string NodeDescription { get; set; }

        [JsonProperty("nodeName")]
        public string NodeName { get; set; }

        [JsonProperty("numExecutors")]
        public int NumExecutors { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("jobs")]
        public JobLink[] JobsLink { get; set; }

        [JsonProperty("overallLoad")]
        public object OverallLoad { get; set; }

        [JsonProperty("primaryView")]
        public object PrimaryView { get; set; }

        [JsonProperty("quietingDown")]
        public bool QuietingDown { get; set; }

        [JsonProperty("slaveAgentPort")]
        public long SlaveAgentPort { get; set; }

        [JsonProperty("unlabeledLoad")]
        public object UnlabeledLoad { get; set; }

        [JsonProperty("useCrumbs")]
        public bool UseCrumbs { get; set; }

        [JsonProperty("useSecurity")]
        public bool UseSecurity { get; set; }

        [JsonProperty("views")]
        public ViewLink[] ViewsLink { get; set; }
    }
}
