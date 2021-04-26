using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class AuthUser
    {
        [Key]
        public long id { get; set; }
        public int functionId { get; set; }
        public long userId { get; set; }
        public string userRights { get; set; }
    }
}
