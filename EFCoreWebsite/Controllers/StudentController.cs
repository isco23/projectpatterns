using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FirstAppEFCore;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Helper;
using FirstAppEFCore.Migrations;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace EFCoreWebsite.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApiHelper<VMStudent> _apiHelper;
        private readonly IConfiguration _configuration;
        private string apiPath;
        public ApiSettings apiSettings { get; set; }
        public StudentController(IConfiguration configuration)
        {
            _apiHelper = new ApiHelper<VMStudent>();
            apiSettings = new ApiSettings();
            apiSettings.ControllerName = "Student2";
            _configuration = configuration;
            apiPath = _configuration.GetValue<string>("apiPath");
        }
        public IActionResult Index()
        {   
            return View();
        }

        public IActionResult Student()
        {
            VMStudent vm = new VMStudent();
            string data = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiPath);
                var responseTask = client.GetAsync("api/student2/GetById/2");                
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    data = readTask.Result;                    
                    vm = JsonConvert.DeserializeObject<VMStudent>(data);                    
                }
            }
            return View(vm);
        }

        public async Task<IActionResult> Insert()
        {
            VMStudent std = new VMStudent()
            {
                Name = "MgMg",
                Address = "Mandalay"
            };

            apiSettings.Action = "add";
            apiSettings.Id = 0;
            apiSettings.Obj = ConvertJson.Serialize(std);
            await _apiHelper.PostRequest(apiPath, apiSettings);
            return View();
        }

        public async Task<IActionResult> GetByName()
        {
            ApiHelper<List<VMStudent>> _apiHelper = new ApiHelper<List<VMStudent>>();
            Student std = new Student()
            {
                Name = "MgMg",
                Address = "Mandalay"
            };
            apiSettings.Action = "getbyname";
            apiSettings.Obj = ConvertJson.Serialize(std);
            List<VMStudent> vMStudents = await _apiHelper.PostRequest(apiPath, apiSettings);
            return View(vMStudents);
        }

        public async Task<IActionResult> GetAll()
        {
            ApiHelper<List<VMStudent>> _apiHelper = new ApiHelper<List<VMStudent>>();
            apiSettings.Action = "getall";
            List<VMStudent> vmStudents = await _apiHelper.GetRequest(apiPath, apiSettings);

            ApiHelper<List<VMCourse>> _apiHelper1 = new ApiHelper<List<VMCourse>>();
            apiSettings.ControllerName = "course";
            apiSettings.Action = "getall";
            List<VMCourse> vmAwards = await _apiHelper1.GetRequest(apiPath,apiSettings);
            return View(vmStudents);
        }

        public async Task<IActionResult> Delete()
        {
            apiSettings.Id = 7;
            apiSettings.Action = "delete";
            bool result = await _apiHelper.DeleteRequest(apiPath,apiSettings);
            return View();
        }
    }
}
