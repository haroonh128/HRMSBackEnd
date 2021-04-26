using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using ServiceLayer;

namespace WebApi.Controllers
{
    public class AuthUserController : Controller
    {
        private readonly IAuthUserService service;
        
        public async Task<ActionResult<IEnumerable<AuthUser>>> Index()
        {
            return await service.GetAuthUsers();
        }

        //public async Task<bool> InsertAuthUser(AuthUser user) {
        //    if (user!=null)
        //    {
                    
        //    }
        //}
    }
}