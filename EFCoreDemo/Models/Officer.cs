using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Officer
    {
        public int OfficerId { get; set; }
        public string OfficerName { get; set; }
        public string OfficerPosition { get; set; }
        public string OfficerNumber { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbTownshipCode { get; set; }
        public string SsbRegionCode { get; set; }
        public int? UserId { get; set; }
        public string LoginType { get; set; }
        public int? LoginId { get; set; }
        public bool? IsActive { get; set; }
    }
}
