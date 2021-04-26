using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace ServiceLayer
{
    public class RolesAuthorization : IRolesAuthorization
    {
        private AuthenticationContext context;
        public RolesAuthorization(AuthenticationContext _context)
        {
            context = _context;
        }

        public async Task<int> SaveRolesAuth(List<Permissions> perms, int roleId)
        {
            RolesAuth auth;
            int result = 0;
            try
            {
                for (int i = 0; i < perms.Count; i++)
                {
                    auth = new RolesAuth();
                    auth.roleId = roleId;
                    auth.permissionId = perms[i].Id;
                    await context.RolesAuth.AddAsync(auth);
                    result = await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return result;
        }

    }
}
