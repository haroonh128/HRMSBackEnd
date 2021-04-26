using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
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
        public DbSet<MstDesignation> mstDesignations { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<RolesAuth> RolesAuth { get; set; }
        public DbSet<DeductionTypes> DeductionTypes { get; set; }
        public DbSet<MstBranches> MstBranches { get; set; }
        public DbSet<MstBranchesDetail> MstBranchesDetail { get; set; }
        public DbSet<AssignRoles> AssignRoles { get; set; }
    }
}
