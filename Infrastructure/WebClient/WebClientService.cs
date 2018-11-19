using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.WebClient
{
    public interface IWebClientService
    {
        Task<TResponse> ExecuteAsync<TResponse>(object data, string method, string url) where TResponse : new();
    }

    public class WebClientService
    {
        IRestClient _restclient = null;

        public WebClientService(IRestClient restClient)
        {
            _restclient = restClient;
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(object data, string method, string url) where TResponse : new()
        {
            RestRequest request = null;
            if (Enum.TryParse(method, true, out Method httpMethod))
            {
                request = new RestRequest
                {
                    Method = httpMethod
                };
            }
            else
            {
                throw new ArgumentException("method is invalid");
            }
            request.RequestFormat = DataFormat.Json;
            request.AddBody(data);
            _restclient.BaseUrl = new System.Uri(url);
            //client.Authenticator = new HttpBasicAuthenticator(_accountSid, _secretKey);
            //request.AddParameter("AccountSid", _accountSid, ParameterType.UrlSegment); // used on every request
            var response = await _restclient.ExecuteTaskAsync<TResponse>(request);

            return response.Data;
        }
    }
}
