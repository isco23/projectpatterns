using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class CashInOut
    {
        public int TransactionId { get; set; }
        public int? EstablishmentId { get; set; }
        public string EstablishmentNo { get; set; }
        public string GeneralPayment { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? Amount { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbInvoiceNo { get; set; }
        public string ReferenceNumber { get; set; }
        public string SsbReceiptNo { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string IsSuccess { get; set; }
        public string BankChannel { get; set; }
        public DateTime? ContributionApprovedDate { get; set; }
        public bool? IsContributionApproved { get; set; }
        public string PaymentType { get; set; }
        public string PaymentReferenceNo { get; set; }
    }
}
