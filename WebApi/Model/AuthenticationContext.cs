using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Sec_UserTypes> sec_UserTypes { get; set; }
        public DbSet<Sec_UserRoles> sec_UserRoles { get; set; }
        public DbSet<AuthUser> MstAuthUser { get; set; }
        public DbSet<MstDepartment> MstDepartment { get; set; }
    }
}
