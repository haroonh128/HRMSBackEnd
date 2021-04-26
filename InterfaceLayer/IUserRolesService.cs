using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IUserRolesService
    {
        Task<string> CreateRoles(Sec_UserRoles roles);
        Task<string> UpdateRoles(Sec_UserRoles sec);
        List<Sec_UserRoles> GetAllRoles();
        Task<string> RemoveRole(Sec_UserRoles sec);
    }
}