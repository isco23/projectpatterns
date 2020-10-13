using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class EmployeeUpload
    {
        public int EmployeeUploadId { get; set; }
        public int EmployeeId { get; set; }
        public string Ssn { get; set; }
        public int EmployeeApplicationId { get; set; }
        public string Upload1 { get; set; }
        public string Upload2 { get; set; }
        public string Upload3 { get; set; }
        public string Upload4 { get; set; }
        public string Upload5 { get; set; }
        public string Upload6 { get; set; }
        public string Upload7 { get; set; }
        public string Upload8 { get; set; }
        public string Upload9 { get; set; }
        public string Upload10 { get; set; }
        public string FpLeft { get; set; }
        public string FpRight { get; set; }
        public string Photo { get; set; }
        public int? UserId { get; set; }
        public bool? IsActive { get; set; }
    }
}
