using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using ServiceLayer;

namespace WebApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _user;
        private IUserManagementService _service;

        public UserProfileController(UserManager<ApplicationUser> user, IUserManagementService service)
        {
            _user = user;
            _service = service;

        }

        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(x => x.Type == "UserID").Value;
            var user = await _user.FindByIdAsync(userId);
            return new
            {
                user.FullName,
                user.UserName,
                user.Email
            };
        }

        [HttpPost]
        [Route("InsertUser")]
        public async Task<bool> InsertUser(ApplicationUserModel formData)
        {
            var result = false;
            try
            {
                if (formData != null)
                {
                    result = await _service.CreateUser(formData);
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        [HttpPost]
        [Route("UpdateUser")]
        public async Task<bool> UpdateUser(ApplicationUserModel formData)
        {
            bool reslt = false;
            if (formData != null)
            {
                //result = await _service.UpdateUser(formData);
                var Model = new ApplicationUser
                {
                    Id = formData.Id,
                    UserName = formData.UserName,
                    FullName = formData.FullName,
                    Email = formData.Email,
                    PasswordHash = formData.Password,
                    PhoneNumber = formData.PhoneNumber,
                    LockoutEnabled = formData.LockoutEnabled,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    NormalizedEmail = formData.NormalizedEmail,
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "",
                    NormalizedUserName = formData.UserName,
                    SecurityStamp = "",
                    TwoFactorEnabled = false
                };
                try
                {
                    IdentityResult result = await _user.UpdateAsync(Model);
                    reslt= result.Succeeded;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return reslt;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        //[Authorize]
        public List<ApplicationUser> GetAllUsers()
        {
            List<ApplicationUser> usrLst = new List<ApplicationUser>();
            try
            {
                return usrLst =  _service.GetUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("RemoveUser")]
        public async Task<bool> RemoveUser(ApplicationUserModel remModel)
        {
            return await _service.RemoveUser(remModel);
        }
    }
}