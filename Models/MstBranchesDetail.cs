using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Models
{
    public class MstBranchesDetail
    {
        [Column(TypeName = "nvarchar(30)")]
        [DisallowNull]
        [Key]
        public string DetailKey { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [ForeignKey("MstBranches")]
        public string BranchID { get; set; }
        [Column(TypeName = "int")]
        [DisallowNull]
        public int LineID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string DocName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string DocSeries { get; set; }
        [Column(TypeName = "int")]
        [AllowNull]
        public int StartingNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [AllowNull]
        public DateTime CreateDt { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [AllowNull]
        public DateTime UpdateDt { get; set; }
        [Column(TypeName = "int")]
        [AllowNull]
        public int LastNumber { get; set; }
        [Column(TypeName = "int")]
        [AllowNull]
        public int SeriesId { get; set; }
        public MstBranches MstBranches { get; set; }
    }
}
