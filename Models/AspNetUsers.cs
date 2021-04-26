using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class AspNetUsers
    {
        [Column("Id",TypeName ="nvarchar(450) not null")]
        public string Id { get; set; }
        [Column("ÜserName",TypeName ="nvarchar(256) null")]
        public string UserName { get; set; }
        [Column("NormalizedUserName",TypeName ="nvarchar(256) null")]
        public string NormalizedUserName { get; set; }
        [Column("Email",TypeName ="nvarchar(256) null")]
        public string Email { get; set; }
        [Column("NormalizedEmail",TypeName ="nvarchar(256) null")]
        public string NormalizedEmail { get; set; }
        [Column("EmailConfirmed",TypeName ="bit notnull")]
        public bool EmailConfirmed { get; set; }
        [Column("PasswordHash", TypeName = "nvarchar(max) null")]
        public string PasswordHash { get; set; }
        [Column("SecurityStamp", TypeName = "nvarchar(max) null")]
        public string SecurityStamp { get; set; }
        [Column("CurrencyStamp", TypeName = "nvarchar(max) null")]
        public string CurrencyStamp { get; set; }
        [Column("PhoneNumber", TypeName = "nvarchar(max) null")]
        public string PhoneNumber { get; set; }
        [Column("PhoneNumberConfirmed", TypeName = "bit not null")]
        public bool PhoneNumberConfirmed { get; set; }
        [Column("TwoFactorEnabled", TypeName = "bit not null")]
        public bool TwoFactorEnabled { get; set; }
        [Column("LockoutEnd", TypeName = "datetimeoffset(7) null")]
        public DateTimeOffset LockoutEnd { get; set; }
        [Column("LockoutEnabled", TypeName = "bit not null")]
        public bool LockoutEnabled { get; set; }
        [Column("AccessFailedCount", TypeName = "int not null")]
        public string AccessFailedCount { get; set; }
        [Column("Discriminator", TypeName = "nvarchar(max) not null")]
        public string Discriminator { get; set; }
        [Column("FullName", TypeName = "nvarchar(150) null")]
        public string FullName { get; set; }
    }
}
