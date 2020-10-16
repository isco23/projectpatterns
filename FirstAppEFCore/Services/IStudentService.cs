using FirstAppEFCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public interface IStudentService : IDisposable
    {
        Task<bool> AddStudent(VMStudent student);
        List<VMStudent> GetByName(VMStudent student);        
    }
}
