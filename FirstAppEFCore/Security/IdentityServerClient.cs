using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Security
{
    public class IdentityServerClient : IIdentityServerClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private string apiPath;
        public IdentityServerClient(HttpClient httpClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = httpClient;
            apiPath = _configuration.GetValue<string>("apiPath");
        }
        public async Task<string> RequestClientCredentialsTokenAsync()
        {
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("username","zarniaung"),
                new KeyValuePair<string, string>("password","isco23")
            });
            string contentType = "multipart/form-data";
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(contentType));
            var tokenResponse = await _httpClient.PostAsync(apiPath, formContent);
            if(tokenResponse.IsSuccessStatusCode == false)
            {
                throw new HttpRequestException("Something went wrong while requesting the access token");
            }
            var stringContent = await tokenResponse.Content.ReadAsStringAsync();
            return JObject.Parse(stringContent)["token"].ToString();
        }
    }
}
