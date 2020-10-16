using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FirstAppEFCore.Helper
{
    public sealed class ApiHelper<T> : IApiHelper<T>
    {
        private static HttpClient client = new HttpClient();

        public async Task<T> GetRequest(string apiPath, ApiSettings apiParam)
        {

            if (apiParam.Id > 0)
            {
                apiPath = apiPath + @"/" + apiParam.ControllerName + @"/" + apiParam.Action + @"/" + apiParam.Id.ToString();
                try
                {
                    var response = await client.GetAsync(apiPath);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        T responseObj = ConvertJson.Deserialize<T>(content);
                        return responseObj;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                apiPath = apiPath + @"/" + apiParam.ControllerName + @"/" + apiParam.Action;
                try
                {
                    var response = await client.GetAsync(apiPath);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        T responseObj = ConvertJson.Deserialize<T>(content);
                        return responseObj;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
         return default(T);
        }

        public async Task<T> PostRequest(string apiPath, ApiSettings apiParam)
        {
            apiPath = apiPath + @"/" + apiParam.ControllerName + @"/" + apiParam.Action;
            string json = JsonConvert.SerializeObject(apiParam);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(apiPath, stringContent);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T responseObject = ConvertJson.Deserialize<T>(content);
                return responseObject;
            }
            return default(T);
        }

        public async Task<bool> PutRequest(string apiPath, ApiSettings apiParam)
        {
            try
            {
                apiPath = apiPath + @"/" + apiParam.ControllerName + @"/" + apiParam.Action;
                string json = JsonConvert.SerializeObject(apiParam);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PatchAsync(apiPath, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        public async Task<bool> DeleteRequest(string apiPath, ApiSettings apiParam)
        {
            try
            {
                if (apiParam.Id > 0)
                {
                    apiPath = apiPath + @"/" + apiParam.ControllerName + @"/" + apiParam.Action + @"/" + apiParam.Id.ToString();
                }
                var response = await client.DeleteAsync(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
    }
}
