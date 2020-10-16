using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EFCoreWebsite.Controllers
{
    public class AwardController : Controller
    {
        private readonly ApiHelper<VMAward> _apiHelper;
        private readonly IConfiguration _configuration;
        private ApiSettings apiSettings;
        private string apiPath;
        public AwardController(IConfiguration configuration)
        {
            _apiHelper = new ApiHelper<VMAward>();
            apiSettings = new ApiSettings();
            apiSettings.ControllerName = "Award";
            _configuration = configuration;
            apiPath = _configuration.GetValue<string>("apiPath");            
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPatch]
        public async Task<IActionResult> Update()
        {
            VMAward vMAward = new VMAward()
            {
                Id = 1,
                Name = "Champion"
            };
            apiSettings.Action = "update";
            apiSettings.Obj = ConvertJson.Serialize(vMAward);
            bool result = await _apiHelper.PutRequest(apiPath, apiSettings);
            return View();
        }
    }
}
