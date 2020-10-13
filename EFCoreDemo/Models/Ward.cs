using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Ward
    {
        public string WardPcode { get; set; }
        public string WardName { get; set; }
        public string SrPcode { get; set; }
        public string DistrictPcode { get; set; }
        public string TownshipPcode { get; set; }
        public bool? IsActive { get; set; }
    }
}
