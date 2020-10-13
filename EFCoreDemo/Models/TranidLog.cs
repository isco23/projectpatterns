using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class TranidLog
    {
        public int Tranid { get; set; }
        public int? UserId { get; set; }
        public string SsbInvoiceNo { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
