using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public interface IStudentService : IDisposable
    {
        Task<Student> AddStudent(Student student);

        //Task<Student> GetStudentById(int id);

        //Task<List<Student>> GetAll();
    }
}
