using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IUserManagementService
    {
        Task<bool> CreateUser(ApplicationUserModel model);
        List<ApplicationUser> GetUsers();
        Task<bool> UpdateUser(ApplicationUserModel model);
        Task<bool> RemoveUser(ApplicationUserModel model);
    }
}