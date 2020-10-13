using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class EmployeeDesignation
    {
        public int EmployeeDesignationId { get; set; }
        public string EmployeeDesignationCode { get; set; }
        public string EmployeeDesignationName { get; set; }
        public string ParentCode { get; set; }
    }
}
