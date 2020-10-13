using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class CbmnetCsvApproved
    {
        public string EstablishmentNo { get; set; }
        public string ReferenceCode { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public int? ApprovedUserId { get; set; }
    }
}
