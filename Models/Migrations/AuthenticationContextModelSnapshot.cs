﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Models.Migrations
{
    [DbContext(typeof(AuthenticationContext))]
    partial class AuthenticationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Models.AssignRoles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createdDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.ToTable("AssignRoles");
                });

            modelBuilder.Entity("Models.AuthUser", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("functionId")
                        .HasColumnType("int");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.Property<string>("userRights")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("MstAuthUser");
                });

            modelBuilder.Entity("Models.DeductionTypes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DeductionTypes");
                });

            modelBuilder.Entity("Models.MstBranches", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("AdvToEmpAcc")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("BankAccout")
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("BlockAfterDueDays")
                        .HasColumnType("int");

                    b.Property<string>("BranchWhs")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CashInHandAccount")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("CostCenter")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateDt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerGroupCode")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ExpenseAccount")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("HeadInTransitWhs")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InTransitWhs")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ItemGroupCode")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("NCControl")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PettyCash")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("SalaryAccount")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("SeriesId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("UpdateDt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Code");

                    b.ToTable("MstBranches");
                });

            modelBuilder.Entity("Models.MstBranchesDetail", b =>
                {
                    b.Property<string>("DetailKey")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("BranchID")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreateDt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DocName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DocSeries")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LastNumber")
                        .HasColumnType("int");

                    b.Property<int>("LineID")
                        .HasColumnType("int");

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.Property<int>("StartingNumber")
                        .HasColumnType("int");

                    b.Property<string>("UpdateDt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DetailKey");

                    b.HasIndex("BranchID");

                    b.ToTable("MstBranchesDetail");
                });

            modelBuilder.Entity("Models.MstDepartment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("code")
                        .HasColumnName("code")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("createdBy")
                        .HasColumnName("createdBy")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("deptHead")
                        .HasColumnType("int");

                    b.Property<int>("deptLevel")
                        .HasColumnType("int");

                    b.Property<string>("deptName")
                        .HasColumnName("deptName")
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("deptPrefix")
                        .HasColumnType("int");

                    b.Property<bool>("flgActive")
                        .HasColumnType("bit");

                    b.Property<int>("parentDept")
                        .HasColumnType("int");

                    b.Property<string>("updatedBy")
                        .HasColumnName("updatedBy")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("MstDepartment");
                });

            modelBuilder.Entity("Models.MstDesignation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("mstDesignations");
                });

            modelBuilder.Entity("Models.Permissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("parentId")
                        .HasColumnName("parentId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnName("url")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Models.RolesAuth", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("permissionId")
                        .HasColumnType("int");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("RolesAuth");
                });

            modelBuilder.Entity("Models.Sec_UserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sec_UserRoles");
                });

            modelBuilder.Entity("Models.Sec_UserTypes", b =>
                {
                    b.Property<int>("userType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("typeId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userType");

                    b.ToTable("sec_UserTypes");
                });

            modelBuilder.Entity("Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(150)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.AssignRoles", b =>
                {
                    b.HasOne("Models.Sec_UserRoles", "Sec_UserRoles")
                        .WithMany()
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.MstBranchesDetail", b =>
                {
                    b.HasOne("Models.MstBranches", "MstBranches")
                        .WithMany()
                        .HasForeignKey("BranchID");
                });
#pragma warning restore 612, 618
        }
    }
}
