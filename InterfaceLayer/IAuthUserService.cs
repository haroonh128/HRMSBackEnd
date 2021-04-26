using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IAuthUserService
    {
        Task<List<AuthUser>> GetAuthUsers();
        Task<bool> Insert(AuthUser obj);
        Task<bool> UpdateAuthUser(AuthUser auth);
    }
}