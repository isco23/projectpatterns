using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Helper;
using FirstAppEFCore.Models;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwardController : BaseController<Award>
    {
        private readonly IAwardService _awardService;
        public AwardController(IBaseService<Award> _award , IAwardService awardService) : base(_award)
        {
            _awardService = awardService;
        }

        [HttpPatch]
        [Route("Update")]
        public IActionResult Update(ApiSettings apiSettings)
        {
            VMAward vMAward = ConvertJson.Deserialize<VMAward>(apiSettings.Obj.ToString());
            bool result = _awardService.Update(vMAward).Result;
            return Ok(result);
        }
    }
}
