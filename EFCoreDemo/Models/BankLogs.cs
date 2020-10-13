using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class BankLogs
    {
        public int Id { get; set; }
        public string BankChannel { get; set; }
        public string ReferenceNumber { get; set; }
        public string TotalAmount { get; set; }
        public string IsSuccess { get; set; }
        public string UpdatedTime { get; set; }
    }
}
