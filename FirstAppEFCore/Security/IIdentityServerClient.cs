using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Security
{
    public interface IIdentityServerClient
    {
        Task<string> RequestClientCredentialsTokenAsync();
    }
}
