using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public class StudentService : IStudentService
    {
        private readonly IBaseService<Student> _studentService;
        public StudentService(IBaseService<Student> studentService)
        {            
            _studentService = studentService;
        }
        public Task<Student> AddStudent(Student student)
        {
            return _studentService.AddAsync(student);            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
