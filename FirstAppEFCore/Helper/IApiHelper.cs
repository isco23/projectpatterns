using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Helper
{
    public interface IApiHelper<T>
    {
        Task<T> GetRequest(string apiPath , ApiSettings apiParam);
        Task<T> PostRequest( string apiPath, ApiSettings apiParam);
        Task<bool> PutRequest(string apiPath, ApiSettings apiParam);
        Task<bool> DeleteRequest(string apiPath, ApiSettings apiParam);
    }
}
