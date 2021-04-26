using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IRolesAuthorization
    {
        Task<int> SaveRolesAuth(List<Permissions> perms, int roleId);
    }
}