using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Township
    {
        public string TownshipPcode { get; set; }
        public string TownshipName { get; set; }
        public string SrPcode { get; set; }
        public string DistrictPcode { get; set; }
        public string SsbOfficeCode { get; set; }
        public string OfficeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
