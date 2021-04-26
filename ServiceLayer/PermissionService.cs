using InterfaceLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class PermissionService : IPermissionService
    {
        private AuthenticationContext context;
        public PermissionService(AuthenticationContext _context)
        {
            context = _context;
        }

        public async Task<string> CreatePermission(Permissions model)
        {
            var result = 0;
            try
            {
                if (model != null)
                {
                    await context.Permissions.AddAsync(model);
                    result = await context.SaveChangesAsync();
                }
                return result.ToString();
            }
            catch (Exception e)
            {
                return result.ToString();
            }
        }

        public async Task<string> UpdatePermission(Permissions model)
        {
            var result = 0;
            try
            {
                if (model != null)
                {
                    context.Permissions.Update(model);
                    result = await context.SaveChangesAsync();
                }
                return result.ToString();
            }
            catch (Exception e)
            {
                return result.ToString();
            }
        }

        public async Task<string> DeletePermission(Permissions model)
        {
            var result = 0;
            try
            {
                if (model != null)
                {
                    context.Permissions.Remove(model);
                    result = await context.SaveChangesAsync();
                }
                return result.ToString();
            }
            catch (Exception e)
            {
                return result.ToString();
            }
        }

        public List<Permissions> GetAllPermission()
        {
            List<Permissions> prmsnLst = new List<Permissions>();
            try
            {
                prmsnLst = context.Permissions.ToList();//OrderBy(x=>x.parentId)
                return prmsnLst;
            }

            catch (Exception e)
            {
                return new List<Permissions>();
            }
        }
    }
}
