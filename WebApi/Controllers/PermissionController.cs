using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private IPermissionService service;
        public PermissionController( IPermissionService _service)
        {
             service = _service;
        }

        [HttpPost]
        [Route("CreatePermission")]
        public async Task<string> CreatePermission(Permissions model)
        {
            var result = "";
            try
            {
                if (model != null)
                {
                    //var obj = new 
                    //{
                    //    Id = model.Id,
                    //    parentId = model.parentId,
                    //    title = model.title,
                    //    url = model.url,
                    //};
                    result = await service.CreatePermission(model);
                }
                return result;
            }
            catch (Exception)
            {

                return result;
            }
        }

        [HttpPost]
        [Route("UpdatePermission")]
        public async Task<string> UpdatePermission(Permissions model)
        {
            var result = "";
            try
            {
                if (model != null)
                {
                    //var obj = new 
                    //{
                    //    Id = model.Id,
                    //    parentId = model.parentId,
                    //    title = model.title,
                    //    url = model.url,
                    //};
                    result = await service.UpdatePermission(model);
                }
                return result;
            }
            catch (Exception)
            {

                return result;
            }
        }

        [HttpPost]
        [Route("DeletePermission")]
        public async Task<string> DeletePermission(Permissions model)
        {
            var result = "";
            try
            {
                if (model != null)
                {
                    result = await service.DeletePermission(model);
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        [HttpGet]
        [Route("GetPermissions")]
        public List<Permissions> GetPermissions()
        {
            try
            {
                return service.GetAllPermission().ToList();
            }
            catch (Exception)
            {
                return new List<Permissions>();
            }
        }
    }
}