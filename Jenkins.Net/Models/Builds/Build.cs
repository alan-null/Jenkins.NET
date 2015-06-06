using System.Linq;
using Newtonsoft.Json;

namespace Jenkins.Net.Models.Builds
{
    public class Build : INavigable
    {
        private object[] _actions;

        [JsonProperty("actions")]
        public object[] Actions
        {
            get
            {
                if (_actions == null || Result == "ABORTED") return null;
                Causes causes = JsonConvert.DeserializeObject<Causes>(_actions[0].ToString());
                Statistics statistics = JsonConvert.DeserializeObject<Statistics>(_actions[5].ToString());
                return new object[]
                    {
                        causes, 
                        statistics
                    };
            }
            set
            {
                object[] x2 = (value.Where(x => x != null).ToArray());
                _actions = x2;
            }
        }

        [JsonProperty("artifacts")]
        public Artifact[] Artifacts { get; set; }

        [JsonProperty("building")]
        public bool Building { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("estimatedDuration")]
        public long EstimatedDuration { get; set; }

        [JsonProperty("executor")]
        public object Executor { get; set; }

        [JsonProperty("fullDisplayName")]
        public string FullDisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("keepLog")]
        public bool KeepLog { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("builtOn")]
        public string BuiltOn { get; set; }

        [JsonProperty("changeSet")]
        public object ChangeSet { get; set; }

        [JsonProperty("culprits")]
        public Culprit[] Culprits { get; set; }

        [JsonProperty("mavenArtifacts")]
        public object MavenArtifacts { get; set; }

        [JsonProperty("mavenVersionUsed")]
        public string MavenVersionUsed { get; set; }

    }
}