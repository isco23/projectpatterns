using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class MpuLog
    {
        public int LogId { get; set; }
        public int? EstablishmentId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? Amount { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbInvoiceNo { get; set; }
        public string MpuReference { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string LogStatus { get; set; }
    }
}
