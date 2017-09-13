using System;
using System.Text;
using RestSharp;

namespace Lob.Core
{
    public class Client
    {
        private readonly RestClient _client;

        public string ApiKey { get; set; }
        public string Version { get; set; }

        public Client(string apikey = null, string version = null)
        {
            if (version != null)
            {
                Version = version;
            }
            
            _client = new RestClient
            {
                Encoding = Encoding.UTF8,
                BaseUrl = new Uri("https://api.lob.com/"),
                Authenticator = new ApiKeyAuthenticator(ApiKey)
            };
        }
    }
}