using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Control
    {
        public int ControlId { get; set; }
        public string ControlName { get; set; }
        public string ControlUrl { get; set; }
        public bool? IsActive { get; set; }
    }
}
