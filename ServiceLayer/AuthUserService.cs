using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer
{
    public class AuthUserService : IAuthUserService


    {
        private readonly AuthenticationContext _user;
        public AuthUserService(AuthenticationContext user)
        {
            _user = user;
        }

        public async Task<bool> Insert(AuthUser obj)
        {
            AuthUser newObj = null;
            var ret = false;
            try
            {
                if (obj != null)
                {
                    newObj = new AuthUser();
                    newObj.userId = obj.userId;
                    newObj.userRights = obj.userRights;
                    newObj.functionId = obj.functionId;
                    await _user.MstAuthUser.AddAsync(newObj);
                    await _user.SaveChangesAsync();
                    return ret = true;
                }
            }
            catch (System.Exception)
            {

                return ret = false;
            }
            return ret;
        }

        public async Task<List<AuthUser>> GetAuthUsers()
        {
            return await _user.MstAuthUser.ToListAsync();
        }

        public async Task<bool> UpdateAuthUser(AuthUser auth)
        {
            AuthUser authUser = null;
            try
            {
                authUser.functionId = auth.functionId;
                authUser.userRights = auth.userRights;
                authUser.userId = auth.userId;
                _user.MstAuthUser.Update(authUser);
                await _user.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

    }
}
