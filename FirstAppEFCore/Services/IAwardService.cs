using FirstAppEFCore.DTO;
using FirstAppEFCore.Models;
using System;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public interface IAwardService : IDisposable
    {
        Task<bool> Update(VMAward award);
    }
}
