using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class SsbReceiptLog
    {
        public string SsbReceiptNo { get; set; }
        public int? UserId { get; set; }
        public string BankReferenceNo { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
