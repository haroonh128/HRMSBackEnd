using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class UserRoles
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string CuncurrencyStamp { get; set; }
    }

    public class AuthReqObj 
    {
        public List<Permissions> model { get; set; }
        public int roleId { get; set; }
    }
}
