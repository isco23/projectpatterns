using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FirstAppEFCore;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace EFCoreWebsite.Controllers
{
    public class StudentController : Controller
    {
        private readonly IConfiguration _configuration;
        private string apiPath;
        public StudentController(IConfiguration configuration)
        {
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
    }
}
