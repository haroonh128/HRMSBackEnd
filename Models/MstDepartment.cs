using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
	public class MstDepartment
	{
		[Key]
		public int id { get; set; }
		public int deptLevel { get; set; }
		[Column("code", TypeName = "nvarchar(50)")]
		public string code { get; set; }
		[Column("deptName", TypeName = "nvarchar(150)")]
		public string deptName { get; set; }
		public int parentDept { get; set; }
		public bool flgActive { get; set; }
		[Column("createdBy", TypeName = "nvarchar(50)")]
		public string createdBy { get; set; }
		[Column("updatedBy", TypeName = "nvarchar(50)")]
		public string updatedBy { get; set; }
		public DateTime createdDate { get; set; }
		public DateTime updatedDate { get; set; }
		public int deptHead { get; set; }
		public int deptPrefix { get; set; }
	}
}