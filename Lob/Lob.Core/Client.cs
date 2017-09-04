using System;
using System.Text;
using RestSharp;

namespace Lob.Core
{
    public class Client
    {
        private readonly RestClient _client;

        public string ApiKey { get; set; }

        public Client()
        {
            _client = new RestClient
            {
                Encoding = Encoding.UTF8,
                BaseUrl = new Uri("https://api.lob.com/"),
                Authenticator = new ApiKeyAuthenticator(ApiKey)
            };
        }
    }
}