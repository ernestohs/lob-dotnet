using System;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;

namespace Lob.Core
{
    internal class ApiKeyAuthenticator : IAuthenticator
    {
        private string ApiKey { get; }

        public string Version { get; set; }

        public ApiKeyAuthenticator(string apiKey, string apiversion = null)
        {
            ApiKey = apiKey + ":";
            Version = apiversion;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            var auth = Convert.ToBase64String(Encoding.Unicode.GetBytes(ApiKey));
            
            request.AddHeader("Basic", auth);
            
            if (!string.IsNullOrWhiteSpace(Version))
            {
                request.AddHeader("Lob-Version", Version);
            }
        }
    }
}