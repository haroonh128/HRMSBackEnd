using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class RolesAuth
    {
        [Key]
        public int id { get; set; }
        public int roleId { get; set; }
        public int permissionId { get; set; }
    }
}
