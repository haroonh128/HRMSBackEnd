using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class DeductionTypes
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public bool isActive { get; set; }
    }
}
