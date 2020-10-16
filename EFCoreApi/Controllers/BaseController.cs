using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreApi.Common;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity> : Controller where TEntity : class
    {
        private  IBaseService<TEntity> _baseService;
        public BaseController(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Task<TEntity> GetById(int id)
        {
            return _baseService.GetById(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_baseService.GetAll());
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<bool> Delete(int id)
        {
            await _baseService.DeleteAsync(id);
            return true;
        }           
    }
}
