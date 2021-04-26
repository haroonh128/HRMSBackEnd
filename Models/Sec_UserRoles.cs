using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Sec_UserRoles
    {
        [Key]
    	public int Id { get; set; }
		public string Name { get; set; }
		public string NormalizedName { get; set; }
    }
}
