using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class TmpCsvData
    {
        public int TranId { get; set; }
        public string EstablishmentNo { get; set; }
        public string ReferenceCode { get; set; }
        public decimal Amount { get; set; }
        public int? UserId { get; set; }
    }
}
