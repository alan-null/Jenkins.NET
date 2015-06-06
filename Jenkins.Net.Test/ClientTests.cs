using System.Linq;
using Jenkins.Net.Models;
using Jenkins.Net.Models.Builds;
using Jenkins.Net.Models.Jobs;
using NUnit.Framework;

namespace Jenkins.Net.Test
{
    [TestFixture]
    public class ClientTests
    {
        public string TestLogin = "user.name";
        public string TestPassword = "password";
        private const string TestHostName = "https://jenkins.company.com/";
        private const string TestJobId = "qa-instance";
        private const int TestJobNumber = 338;
        private const string TestViewName = "Company-Project";

        [Test]
        public void LoginTest()
        {
            JenkinsClient client = new JenkinsClient(TestHostName);
            client.LogIn(TestLogin, TestPassword);
        }

        [Test]
        public void Get_job_with_job_id()
        {
            JenkinsClient client = new JenkinsClient(TestHostName);
            client.LogIn(TestLogin, TestPassword);
            Job job = client.GetJob(TestJobId);
            Assert.NotNull(job);
        }

        [Test]
        public void Get_build_with_job_id_and_build_number()
        {
            JenkinsClient client = new JenkinsClient(TestHostName);
            client.LogIn(TestLogin, TestPassword);
            Build build = client.GetBuild(TestJobId, TestJobNumber);
            Assert.NotNull(build);
        }

        [Test]
        public void Get_build_with_build_link()
        {
            JenkinsClient client = new JenkinsClient(TestHostName);
            client.LogIn(TestLogin, TestPassword);
            Job job = client.GetJob(TestJobId);
            BuildLink link = job.BuildsLink.FirstOrDefault();
            Build build = client.GetBuild(link);
            Assert.NotNull(build);
        }

        [Test]
        public void Get_last_build_with_job_id()
        {
            JenkinsClient client = new JenkinsClient(TestHostName);
            client.LogIn(TestLogin, TestPassword);
            Build build = client.GetLastBuild(TestJobId);            
            Assert.NotNull(build);
        }

        [Test]
        public void Get_view_with_view_id()
        {
            JenkinsClient client = new JenkinsClient(TestHostName);
            client.LogIn(TestLogin, TestPassword);
            View view = client.GetView(TestViewName);
            Assert.NotNull(view);
        }
    }
}
