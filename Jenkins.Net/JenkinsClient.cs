using System;
using System.Net;
using Jenkins.Net.Exceptions;
using Jenkins.Net.Models;
using Jenkins.Net.Models.Builds;
using Jenkins.Net.Models.Jobs;
using Newtonsoft.Json;
using RestSharp;

namespace Jenkins.Net
{
    public class JenkinsClient
    {
        private readonly string _hostName;
        protected RestClient Client { get; set; }

        public JenkinsClient(string hostName)
        {
            _hostName = hostName;
            Client = new RestClient(_hostName);
        }

        public void LogIn(string login, string password)
        {
            Client.Authenticator = new HttpBasicAuthenticator(login, password);
        }

        public Job GetJob(string job)
        {
            Client.BaseUrl = BuildJobJsonApiUri(job);
            return ExecuteRequest<Job>();
        }

        public string GetJobTrendUrl(string job)
        {
            return String.Format("{0}/job/{1}/test/trend", _hostName, job);
        }

        public byte[] GetJobTrendImage(string job)
        {
            Client.BaseUrl = new Uri(GetJobTrendUrl(job));
            return Client.Execute(new RestRequest(Method.GET)).RawBytes;
        }

        public Build GetBuild(string job, int jobNumber)
        {
            Client.BaseUrl = BuildJobJsonApiUri(job, jobNumber);
            return ExecuteRequest<Build>();
        }

        public Build GetBuild(BuildLink buildLink)
        {
            Client.BaseUrl = BuildBuildJsonApiUri(buildLink.Url);
            return ExecuteRequest<Build>();
        }

        public Build GetLastBuild(string job)
        {
            Job jobObj = GetJob(job);
            return GetBuild(jobObj.BuildsLink[0]);
        }

        public View GetView(string view)
        {
            Client.BaseUrl = BuildViewJsonApiUri(view);
            return ExecuteRequest<View>();
        }

        private Uri BuildViewJsonApiUri(string job)
        {
            string url = String.Format("{0}/view/{1}/api/json", _hostName, job);
            return new Uri(url);
        }

        private Uri BuildBuildJsonApiUri(string job)
        {
            string url = String.Format("{0}/api/json",  job);
            return new Uri(url);
        }

        private Uri BuildJobJsonApiUri(string job)
        {
            string url = String.Format("{0}/job/{1}/api/json", _hostName, job);
            return new Uri(url);
        }

        private Uri BuildJobJsonApiUri(string job, int jobNumber)
        {
            string url = String.Format("{0}/job/{1}/{2}/api/json", _hostName, job, jobNumber);
            return new Uri(url);
        }

        private T ExecuteRequest<T>()
        {
            IRestResponse restResponse = Client.Execute(new RestRequest(Method.GET));
            if (restResponse.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<T>(restResponse.Content);
            }
            throw new JenkinsConnectionException(restResponse.StatusCode);
        }
    }
}
