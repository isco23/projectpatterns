using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore
{
    public interface ICourseService : IDisposable
    {
        Task<bool> AddCourseAsync(Course newCourse);
    }
}
