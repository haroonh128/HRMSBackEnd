using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class AssignRoles
    {
        public int id { get; set; }
        [ForeignKey("Sec_UserRoles")]
        public int roleId { get; set; }
        public string userId { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string updatedBy { get; set; }
        public string updatedDate { get; set; }
        public Sec_UserRoles Sec_UserRoles { get; set; }
    }
}
