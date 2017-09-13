using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

            if (apikey != null)
            {
                ApiKey = apikey;
            }

            _client = new RestClient
            {
                Encoding = Encoding.UTF8,
                BaseUrl = new Uri("https://api.lob.com/"),
                Authenticator = new ApiKeyAuthenticator(ApiKey, Version),
                UserAgent = "lob-net"
            };
        }

        public Task<T> Get<T>(string resource, IEnumerable<KeyValuePair<string, object>> parameters = null)
            where T : class, new()
        {
            IRestRequest request = new RestRequest();
            request.Resource = resource;

            if (parameters == null) return _client.GetTaskAsync<T>(request);
            
            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter.Key, parameter.Value);
            }

            return _client.GetTaskAsync<T>(request);
        }

        public Task<T> Delete<T>(string resource) where T : class, new()
        {
            IRestRequest request = new RestRequest();
            request.Resource = resource;
            return _client.DeleteTaskAsync<T>(request);
        }

        public Task<TResponse> Post<TResponse, TRequest>(string resource, TRequest requestObject)
            where TResponse : class, new()
        {
            IRestRequest request = new RestRequest();
            request.Resource = resource;
            request.AddBody(requestObject);
            return _client.PostTaskAsync<TResponse>(request);
        }
    }
}