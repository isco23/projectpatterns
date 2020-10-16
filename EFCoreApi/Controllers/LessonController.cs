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
    public class LessonController : BaseController<Lesson>
    {
        private readonly ILessonService _lessonService;
        public LessonController(IBaseService<Lesson> _lesson , ILessonService lessonService ) : base(_lesson)
        {
            _lessonService = lessonService;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddLesson(ApiSettings apiSettings)
        {
            VMLesson lesson = ConvertJson.Deserialize<VMLesson>(apiSettings.Obj.ToString());
            _lessonService.AddLesson(lesson);
            return Ok("Success");
        }

        [HttpPost]
        [Route("AddList")]
        public IActionResult AddLessonList(ApiSettings apiSettings)
        {
            List<VMLesson> lesson = ConvertJson.Deserialize<List<VMLesson>>(apiSettings.Obj.ToString());
            _lessonService.AddLessonList(lesson);
            return Ok("Success");
        }        
    }
}
