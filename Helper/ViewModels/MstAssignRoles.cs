using System;
using System.Collections.Generic;
using System.Text;

namespace Helper.ViewModels
{
    public class MstAssignRoles
    {
        public int id { get; set; }
        public int roleId { get; set; }
        public string userId { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string updatedBy { get; set; }
        public string updatedDate { get; set; }
    }

    public class Response {
        public int id { get; set; }
        public int roleId { get; set; }
        public string userId { get; set; }
        public string name { get; set; }
        public string fullName { get; set; }
    }
    public class Id {
        public string id { get; set; }
    }
}
