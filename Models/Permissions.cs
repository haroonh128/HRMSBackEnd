using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Permissions
    {
        [Key]
        [Column("Id",Order =0)]
        public int Id { get; set; }
        
        [Column("parentId",Order =1)]
        [Required]
        public int parentId { get; set; }

        [Column("title",Order =2)]
        [StringLength(200)]
        [Required]
        public string title { get; set; }

        [Column("url", Order = 3)]
        [StringLength(500)]
        [Required]
        public string url { get; set; }

    }
}
