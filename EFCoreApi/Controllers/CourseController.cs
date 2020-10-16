using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAppEFCore;
using FirstAppEFCore.Helper;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : BaseController<Course>
    {
        private readonly ICourseService _courseService;
        public CourseController(IBaseService<Course> _course , ICourseService courseService) : base(_course)
        {
            _courseService = courseService;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddCourse(ApiSettings apiSettings)
        {
            Course c = JsonConvert.DeserializeObject<Course>(apiSettings.Obj.ToString());
            _courseService.AddCourseAsync(c);
            return Ok("Success");
        }
    }
}
