using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAppEFCore.Models;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : BaseController<Teacher> 
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(IBaseService<Teacher> _teacher, ITeacherService teacherService) : base(_teacher)
        {
            _teacherService = teacherService;
        }
    }
}
