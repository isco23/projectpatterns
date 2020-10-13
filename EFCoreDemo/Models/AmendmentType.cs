using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class AmendmentType
    {
        public int AmendmentTypeId { get; set; }
        public string AmendmentTypeName { get; set; }
        public string Owner { get; set; }
    }
}
