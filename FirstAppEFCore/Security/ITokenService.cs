using System.Threading.Tasks;

namespace FirstAppEFCore.Security
{
    public interface ITokenService
    {
        Task<string> FetchToken();
    }
}
