using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Sec_UserTypes
    {
        [Key]
        public int userType { get; set; }
        public string typeId { get; set; }
    }
}
