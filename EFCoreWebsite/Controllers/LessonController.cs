using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Helper;
using FirstAppEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EFCoreWebsite.Controllers
{
    public class LessonController : Controller
    {
        private ApiHelper<Lesson> _apiHelper;
        private readonly IConfiguration _configuration;
        public ApiSettings apiSettings { get; set; }
        private string apiPath;
        public LessonController(IConfiguration configuration)
        {
            _apiHelper = new ApiHelper<Lesson>();
            apiSettings = new ApiSettings();
            apiSettings.ControllerName = "Lesson";
            _configuration = configuration;
            apiPath = _configuration.GetValue<string>("apiPath");
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Insert()
        {
            FirstAppEFCore.DTO.VMLesson ls = new FirstAppEFCore.DTO.VMLesson()
            {
                Subject = "AI"
            };

            apiSettings.Action = "add";
            apiSettings.Id = 0;
            apiSettings.Obj = ConvertJson.Serialize(ls);
            await _apiHelper.PostRequest(apiPath, apiSettings);
            return View();
        }

        public async Task<IActionResult> InsertList()
        {
            List<VMLesson> lessonList = new List<VMLesson>()
            {
                new VMLesson()
                {
                    Subject = "CO"
                },
                    new VMLesson()
                {
                    Subject = "SE"
                },
            };
            apiSettings.Action = "addlist";
            apiSettings.Id = 0;
            apiSettings.Obj = ConvertJson.Serialize(lessonList);
            await _apiHelper.PostRequest(apiPath, apiSettings);
            return View();
        }

        public async Task<IActionResult> GetList()
        {
            ApiHelper<List<VMLesson>> _apiHelper = new ApiHelper<List<VMLesson>>();
            apiSettings.Action = "getall";
            apiSettings.Id = 0;
            List<VMLesson> lessonList = await _apiHelper.GetRequest(apiPath, apiSettings);            
            return View(lessonList);
        }
    }
}
