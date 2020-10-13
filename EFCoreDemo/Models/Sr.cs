using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Sr
    {
        public string SrPcode { get; set; }
        public string SrName { get; set; }
        public bool? IsActive { get; set; }
    }
}
