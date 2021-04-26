using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Models
{
    public class MstBranches
    {
        [DisallowNull]
        [Column(TypeName = "nvarchar(10)")]
        [Key]
        public string Code { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string SeriesId { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string BankAccout { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string CashInHandAccount { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string PettyCash { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string ExpenseAccount { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BranchWhs { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string InTransitWhs { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string HeadInTransitWhs { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDt { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDt { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string CostCenter { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string CustomerGroupCode { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string ItemGroupCode { get; set; }
        [Column(TypeName = "int")]
        public int BlockAfterDueDays { get; set; }
        [Column(TypeName = "int")]
        [AllowNull]
        public int NCControl { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string SalaryAccount { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string AdvToEmpAcc { get; set; }
    }
}
