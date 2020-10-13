using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class CbmnetCsv
    {
        public int Id { get; set; }
        public string EstablishmentNo { get; set; }
        public string ReferenceCode { get; set; }
        public decimal Amount { get; set; }
        public string Path { get; set; }
        public DateTime? ImportDateTime { get; set; }
        public int? ImportUserId { get; set; }
    }
}
