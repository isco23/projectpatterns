using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class District
    {
        public string DistrictPcode { get; set; }
        public string DistrictName { get; set; }
        public string SrPcode { get; set; }
        public bool? IsActive { get; set; }
    }
}
