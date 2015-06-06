using Newtonsoft.Json;

namespace Jenkins.Net.Models.Jobs
{
    public class Job : Page
    {
        [JsonProperty("actions")]
        public object[] Actions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("buildable")]
        public bool Buildable { get; set; }

        [JsonProperty("builds")]
        public BuildLink[] BuildsLink { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("firstBuild")]
        public BuildLink FirstBuildLink { get; set; }

        [JsonProperty("healthReport")]
        public HealthReport[] HealthReport { get; set; }

        [JsonProperty("inQueue")]
        public bool InQueue { get; set; }

        [JsonProperty("keepDependencies")]
        public bool KeepDependencies { get; set; }

        [JsonProperty("lastBuild")]
        public BuildLink LastBuildLink { get; set; }

        [JsonProperty("lastCompletedBuild")]
        public BuildLink LastCompletedBuildLink { get; set; }

        [JsonProperty("lastFailedBuild")]
        public BuildLink LastFailedBuildLink { get; set; }

        [JsonProperty("lastStableBuild")]
        public BuildLink LastStableBuildLink { get; set; }

        [JsonProperty("lastSuccessfulBuild")]
        public BuildLink LastSuccessfulBuildLink { get; set; }

        [JsonProperty("lastUnstableBuild")]
        public BuildLink LastUnstableBuildLink { get; set; }

        [JsonProperty("lastUnsuccessfulBuild")]
        public BuildLink LastUnsuccessfulBuildLink { get; set; }

        [JsonProperty("nextBuildNumber")]
        public int NextBuildNumber { get; set; }

        [JsonProperty("property")]
        public object Property { get; set; }

        [JsonProperty("queueItem")]
        public object QueueItem { get; set; }

        [JsonProperty("concurrentBuild")]
        public object ConcurrentBuild { get; set; }

        [JsonProperty("downstreamProjects")]
        public object DownstreamProjects { get; set; }

        [JsonProperty("scm")]
        public object Scm { get; set; }

        [JsonProperty("upstreamProjects")]
        public object UpstreamProjects { get; set; }

        [JsonProperty("modules")]
        public object Modules { get; set; }
    }
}
