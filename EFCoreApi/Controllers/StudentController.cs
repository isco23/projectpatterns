using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AutoMapper;
using EFCoreApi.Common;
using FirstAppEFCore;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EFCoreApi.Controllers
{
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IBaseService<Student> _baseService;
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IMapper mapper,IStudentService studentService, IBaseService<Student> baseService)
        {
            _baseService = baseService;
            _mapper = mapper;
            _studentService = studentService;
        }

        [Route("all")]
        //public async Task<List<Student>> GetAll()
        public async Task<ActionResult<IEnumerable<VMStudent>>> GetAll()
        {
            var studentList = await _baseService.GetAll().ToListAsync();            
            var vmStd = _mapper.Map<List<VMStudent>>(studentList);            
            return vmStd;
        }

        [Route("json")]
        public async Task<IActionResult> GetJson()
        {
            var studentList = await _baseService.GetAll().ToListAsync();
            var std = _mapper.Map<List<VMStudent>>(studentList);            
            string json = ConvertJson.Serialize(std);
            return Ok(json);
        }
    }
}
