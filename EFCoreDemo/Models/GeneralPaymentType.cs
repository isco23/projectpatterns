using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class GeneralPaymentType
    {
        public int GeneralPaymentTypeId { get; set; }
        public string GeneralPaymentTypeName { get; set; }
        public int? LawId { get; set; }
    }
}
