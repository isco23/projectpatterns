using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FirstAppEFCore;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EFCoreWebsite.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApiHelper<VMCourse> _apiHelper;
        private readonly IConfiguration _configuration;
        public ApiSettings apiSettings { get; set; }
        private string apiPath;
        public CourseController(IConfiguration configuration)
        {
            _apiHelper = new ApiHelper<VMCourse>();
            apiSettings = new ApiSettings();
            apiSettings.ControllerName = "Course";
            _configuration = configuration;
            apiPath = _configuration.GetValue<string>("apiPath");            
        }
        public async Task<IActionResult> Index()
        {
            //ApiHelper<Course> _apiHelper = new ApiHelper<Course>();
            apiSettings.Id = 1;
            await _apiHelper.GetRequest(apiPath, apiSettings);
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<List<VMCourse>>> GetAll()
        {
            apiSettings.Action = "getall";
            await _apiHelper.GetRequest(apiPath, apiSettings);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert()
        {
            apiSettings.Action = "add";
            apiSettings.Id = 0;
            apiSettings.Obj = "{ \"CourseName\" : \"PRE\" }";
            await _apiHelper.PostRequest(apiPath, apiSettings);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            ApiHelper<List<VMCourse>> _apiHelper = new ApiHelper<List<VMCourse>>();
            apiSettings.Action = "getall";
            List<VMCourse> courseList = await _apiHelper.GetRequest(apiPath, apiSettings);
            return View(courseList);
        }

        [HttpGet]
        public async Task<IActionResult> GetById()
        {            
            apiSettings.Action = "getbyid";
            apiSettings.Id = 4;
            VMCourse course = await _apiHelper.GetRequest(apiPath, apiSettings);
            return View(course);
        }
    }
}
