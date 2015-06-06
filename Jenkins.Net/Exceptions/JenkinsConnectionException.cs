using System;
using System.Net;

namespace Jenkins.Net.Exceptions
{
    internal class JenkinsConnectionException : Exception
    {
        public JenkinsConnectionException(string toString)
            : base(toString)
        {
        }

        public JenkinsConnectionException(HttpStatusCode code)
            : base(String.Format("Could not execute request, status code: {0}", code))
        {
        }
    }
}