using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class TmpPenaltyAllEstablishment
    {
        public int? EstablishmentId { get; set; }
        public string EstablishmentNo { get; set; }
        public string EstablishmentNameMyanmar { get; set; }
        public string EstablishmentNameEnglish { get; set; }
        public string UserEmail { get; set; }
        public int? UserId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? EmployeeCount { get; set; }
        public decimal? Law1Total { get; set; }
        public decimal? Law1Penalty { get; set; }
        public decimal? Law2Total { get; set; }
        public decimal? Law2Penalty { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? PenaltyTotal { get; set; }
        public decimal? NetAmount { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbOfficeName { get; set; }
        public string SsbInvoiceNo { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string PaymentType { get; set; }
        public int? TotalLateDay { get; set; }
        public bool? IsPaid { get; set; }
        public bool? IsAdditionalUnPaid { get; set; }
    }
}
