using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Security
{
    public class TokenService : ITokenService
    {
        private readonly IMemoryCache _cache;
        private readonly IIdentityServerClient _identityServerClient;
        private IConfiguration _configuration;
        private string apiPath;
        private string expiredTime;
        public TokenService(IMemoryCache cache, IIdentityServerClient identityServerClient,IConfiguration configuration)
        {
            _cache = cache;
            _identityServerClient = identityServerClient;
            _configuration = configuration;
            apiPath = _configuration.GetValue<string>("apiPath");
            expiredTime = _configuration.GetValue<string>("TokenExpiresIn");
        }
        public async Task<string> FetchToken()
        {
            string token = string.Empty;
            if(!_cache.TryGetValue("TOKEN",out token))
            {
                var tokenString = await this.GetTokenFromApi();
                int.TryParse(expiredTime, out int expiresIn);
                if (expiresIn == 0) expiresIn = 3;
                var options = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(expiresIn * 60));
                _cache.Set("TOKEN", tokenString, options);
                token = tokenString;                
            }
            else
            {

            }
            return token;
            
        }
        private async Task<string> GetTokenFromApi()
        {
            // request the access token
            var accessToken = await _identityServerClient.RequestClientCredentialsTokenAsync();
            return accessToken;
        }
    }
}
