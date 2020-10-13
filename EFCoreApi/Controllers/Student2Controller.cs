using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAppEFCore;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student2Controller : BaseController<Student>
    {
        private readonly IStudentService _studentService;
        public Student2Controller(IBaseService<Student> _student , IStudentService studentService) : base(_student)
        {
            _studentService = studentService;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddStudent(Student student)
        {
            _studentService.AddStudent(student);
            return Ok("Success");
        }


    }
}
