using Microsoft.AspNetCore.Identity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class UserRolesService : IUserRolesService
    {
        private AuthenticationContext _context;
        public UserRolesService(AuthenticationContext context)//RoleManager<Sec_UserRoles> roleManager)
        {
            // _roleManager=roleManager;
            _context = context;
        }

        public async Task<string> CreateRoles(Sec_UserRoles roles)
        {
            var Model = new Sec_UserRoles
            {
                Name = roles.Name,
                NormalizedName = roles.NormalizedName,
                //CuncurrencyStamp = roles.CuncurrencyStamp,
            };
            try
            {
                await _context.sec_UserRoles.AddAsync(Model);
                var result = await _context.SaveChangesAsync();
                return result.ToString();
                //_roleManager.CreateAsync(Model);
                //return result..Succeeded;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> UpdateRoles(Sec_UserRoles sec)
        {
            var Model = new Sec_UserRoles
            {
                Id = sec.Id,
                Name = sec.Name,
                NormalizedName = sec.NormalizedName,
                //CuncurrencyStamp = sec.CuncurrencyStamp
            };
            try
            {
                _context.sec_UserRoles.Update(Model);
                var result = await _context.SaveChangesAsync();
                return result.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Sec_UserRoles> GetAllRoles()
        {
            //List<Sec_UserRoles> userRoles = new List<Sec_UserRoles>();
            try
            {
                var result = _context.sec_UserRoles;
                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> RemoveRole(Sec_UserRoles sec)
        {
            try
            {
                _context.sec_UserRoles.Remove(sec);
                var result = await _context.SaveChangesAsync();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
