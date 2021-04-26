using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IPermissionService
    {
        Task<string> CreatePermission(Permissions model);
        Task<string> DeletePermission(Permissions model);
        List<Permissions> GetAllPermission();
        Task<string> UpdatePermission(Permissions model);
    }
}
