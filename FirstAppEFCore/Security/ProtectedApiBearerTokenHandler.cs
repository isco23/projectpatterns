using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstAppEFCore.Security
{
    public class ProtectedApiBearerTokenHandler : DelegatingHandler
    {
        private readonly IIdentityServerClient _identityServerClient;
        private readonly ITokenService _tokenService;
        public ProtectedApiBearerTokenHandler(IIdentityServerClient identityServerClient , ITokenService tokenService)
        {
            _identityServerClient = identityServerClient ?? throw new ArgumentNullException(nameof(identityServerClient));
            _tokenService = tokenService;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var accessToken = await _tokenService.FetchToken();
            request.Headers.Add("Authorization", String.Format("Bearer {0}", accessToken));
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
