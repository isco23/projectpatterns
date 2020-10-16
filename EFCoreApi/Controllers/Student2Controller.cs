using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Threading.Tasks;
using FirstAppEFCore;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Helper;
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
        public Student2Controller(IBaseService<Student> _student, IStudentService studentService) : base(_student)
        {
            _studentService = studentService;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddStudent(ApiSettings apiSettings)
        {
            VMStudent std = ConvertJson.Deserialize<VMStudent>(apiSettings.Obj.ToString());
            _studentService.AddStudent(std);
            return Ok("Success");
        }

        [HttpPost]
        [Route("GetByName")]
        public  IActionResult GetByName([FromBody]ApiSettings apiSettings)
        {
            VMStudent std = ConvertJson.Deserialize<VMStudent>(apiSettings.Obj.ToString());
            List<VMStudent> vmStd = _studentService.GetByName(std);
            return Json(vmStd);
        }        
    }
}
