using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;
using Helper.ViewModels;

namespace ServiceLayer
{
    public class AssignRolesService : IAssignRolesService
    {
        private AuthenticationContext cont;
        public AssignRolesService(AuthenticationContext _cont)
        {
            cont = _cont;
        }

        public async Task<List<Response>> GetRolesByUserId(string userID)
        {
            List<Response> rspLst = new List<Response>();
            Response rsp = new Response();
            userID = userID.Trim();
            try
            {
                var lst = (from a in cont.AssignRoles
                           join b in cont.applicationUsers on a.userId equals b.Id
                           join c in cont.sec_UserRoles on a.roleId equals c.Id
                           where b.Id == userID
                           orderby a.id
                           select new
                           {
                               b.FullName,
                               c.Name,
                               a.id,
                               a.roleId,
                               b.Id,
                           }).ToList();

                foreach (var i in lst)
                {
                    rsp.roleId = i.roleId;
                    rsp.userId = i.Id;
                    rsp.name = i.Name;
                    rsp.fullName = i.FullName;
                    rsp.id = i.id;
                    rspLst.Add(rsp);
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return rspLst;
        }

        public async Task<List<ApplicationUser>> GetAllUsers()
        {
            List<ApplicationUser> rspLst = new List<ApplicationUser>();
            try
            {
                rspLst = cont.applicationUsers.ToList();
            }
            catch (Exception e)
            {
                throw;
            }
            return rspLst;
        }

        public async Task<int> SaveUserRoles(MstAssignRoles roles)
        {
            int result = 0;
            AssignRoles obj = new AssignRoles();
            try
            {
                obj.userId = roles.userId;
                obj.roleId = roles.roleId;
                obj.id = roles.id;
                obj.createdDate = roles.createdDate;
                obj.updatedDate = DateTime.Now.ToString();
                await cont.AssignRoles.AddAsync(obj);
                result = await cont.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
            return result;
        }

        public async Task<int> DeleteUserRoles(MstAssignRoles roles)
        {
            int result = 0;
            AssignRoles obj = new AssignRoles();

            try
            {
                obj.userId = roles.userId;
                obj.roleId = roles.roleId;
                obj.id = roles.id;
                obj.createdDate = roles.createdDate;
                obj.updatedDate = DateTime.Now.ToString();
                cont.AssignRoles.Remove(obj);
                result = await cont.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
            return result;
        }
    }
}
