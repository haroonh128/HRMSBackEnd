using Helper.ViewModels;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IAssignRolesService
    {
        Task<List<Response>> GetRolesByUserId(string userID);
        Task<List<ApplicationUser>> GetAllUsers();
        Task<int> SaveUserRoles(MstAssignRoles roles);
        Task<int> DeleteUserRoles(MstAssignRoles roles);
    }
}