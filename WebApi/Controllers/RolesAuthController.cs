using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InterfaceLayer;
using WebApi.Model;
using Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesAuthController : ControllerBase
    {
        private IRolesAuthorization authorization;
        public RolesAuthController(IRolesAuthorization _authorization)
        {
            authorization = _authorization;
        }

        [HttpPost]
        [Route("SaveRolesAuth")]
        public async Task<int> SaveRolesAuth(AuthReqObj model)//List<Permissions> model,int roleId) 
        {
            int result = 0;
            try
            {
                result=await authorization.SaveRolesAuth(model.model,model.roleId);
            }
            catch (Exception e)
            {

                throw;
            }
            return result;
        }
    }
}