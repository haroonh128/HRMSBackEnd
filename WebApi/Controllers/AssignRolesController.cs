using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helper.ViewModels;
using InterfaceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignRolesController : ControllerBase
    {
        public IAssignRolesService service;
        public AssignRolesController(IAssignRolesService _service)
        {
            service = _service;
        }

        [HttpPost]
        [Route("GetRolesById")]
        public async Task<List<Response>> GetRolesById(Id id)
        {
            List<Response> rspLst = new List<Response>();
            try
            {
                rspLst = await service.GetRolesByUserId(id.id);
            }
            catch (Exception e)
            {
                throw;
            }
            return rspLst;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<List<ApplicationUser>> GetAllUsers()
        {
            List<ApplicationUser> rspLst = new List<ApplicationUser>();
            try
            {
                rspLst = await service.GetAllUsers();
            }
            catch (Exception e)
            {
                throw;
            }
            return rspLst;
        }

        [HttpPost]
        [Route("SaveUserRoles")]
        public async Task<int> SaveUserRoles(MstAssignRoles form)
        {
            int result = 0;
            try
            {
                result = await service.SaveUserRoles(form);
            }
            catch (Exception e)
            {
                throw;
            }
            return result;
        }

        [HttpPost]
        [Route("DeleteUserRoles")]
        public async Task<int> DeleteUserRoles(MstAssignRoles form)
        {
            int result = 0;
            try
            {
                result = await service.DeleteUserRoles(form);
            }
            catch (Exception e)
            {
                throw;
            }
            return result;
        }
    }
}