using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Classes
{
    public class DepartmentClass
    {
    }

    public class deptObject {
		public int id { get; set; }
		public int deptLevel { get; set; }
		public string code { get; set; }
		public string deptName { get; set; }
		public int parentDept { get; set; }
		public bool flgActive { get; set; }
		public string createdBy { get; set; }
		public string updatedBy { get; set; }
		public DateTime createdDate { get; set; }
		public DateTime updatedDate { get; set; }
		public int deptHead { get; set; }
		public int deptPrefix { get; set; }
	}

	public class deptListObject
	{
		public int id { get; set; }
		public int deptLevel { get; set; }
		public string code { get; set; }
		public string deptName { get; set; }
		public int parentDept { get; set; }
		public bool flgActive { get; set; }
		public string createdBy { get; set; }
		public string updatedBy { get; set; }
		public DateTime createdDate { get; set; }
		public DateTime updatedDate { get; set; }
		public int deptHead { get; set; }
		public int deptPrefix { get; set; }
	}
}
