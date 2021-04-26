using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class UserManagementService : IUserManagementService
    {
        private UserManager<ApplicationUser> _context;
        private AuthenticationContext _cont;


        public UserManagementService(UserManager<ApplicationUser> context, AuthenticationContext cont)
        {
            _context = context;
            _cont = cont;
        }

        public async Task<bool> CreateUser(ApplicationUserModel model)
        {
            var Model = new ApplicationUser()
            {
                UserName = model.UserName,
                FullName = model.FullName,
                Email = model.Email,
                PasswordHash = model.Password,
                PhoneNumber = model.PhoneNumber,
                LockoutEnabled = model.LockoutEnabled,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = model.NormalizedEmail
            };
            try
            {
                var result = await _context.CreateAsync(Model, model.Password);
                return result.Succeeded;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateUser(ApplicationUserModel model)
        {
            ApplicationUser a =await _context.FindByIdAsync(model.Id);
            var Model = new ApplicationUser
            {
                Id = model.Id,
                UserName = model.UserName,
                FullName = model.FullName,
                Email = model.Email,
                PasswordHash = model.Password,
                PhoneNumber = model.PhoneNumber,
                LockoutEnabled = model.LockoutEnabled,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = model.NormalizedEmail,
                AccessFailedCount = 0,
                ConcurrencyStamp = "",
                NormalizedUserName = model.UserName,
                SecurityStamp = "",
                TwoFactorEnabled = false
            };
            try
            {
                IdentityResult result = await _context.UpdateAsync(Model);
                return result.Succeeded;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ApplicationUser> GetUsers()
        {
            try
            {
                List<ApplicationUserModel> users = new List<ApplicationUserModel>();
                var response = _context.Users.AsQueryable();
                return response.ToList();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<bool> RemoveUser(ApplicationUserModel model)
        {
            var Model = new ApplicationUser();
            Model = await _context.FindByIdAsync(model.Id);
            try
            {
                var result = await _context.DeleteAsync(Model);
                return result.Succeeded;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}