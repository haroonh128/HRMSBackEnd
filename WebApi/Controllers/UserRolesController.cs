using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using ServiceLayer;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private IUserRolesService _service;
        public UserRolesController(IUserRolesService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateRole")]
        public async Task<string> CreateRole(Sec_UserRoles formModel)
        {
            return await _service.CreateRoles(formModel);
        }

        [HttpPost]
        [Route("UpdateRole")]
        public async Task<string> UpdateRole(Sec_UserRoles formModel)
        {
            return await _service.UpdateRoles(formModel);
        }

        [HttpGet]
        [Route("GetAllRoles")]
        public List<Sec_UserRoles> GetAllRoles()
        {
            return _service.GetAllRoles();
        }

        [HttpPost]
        [Route("RemoveRole")]
        public async Task<string> RemoveRole(Sec_UserRoles remModel)
        {
            return await _service.RemoveRole(remModel);
        }
    }
}