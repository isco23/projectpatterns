using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class GeneralPayment
    {
        public int GeneralPaymentId { get; set; }
        public string SsbInvoiceNo { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public int? GeneralPaymentTypeId { get; set; }
        public int? LawId { get; set; }
        public decimal? Amount { get; set; }
        public int? UserId { get; set; }
        public int? EstablishmentId { get; set; }
        public string EstablishmentNo { get; set; }
        public string IsSuccess { get; set; }
        public string BankChannel { get; set; }
        public string PaymentType { get; set; }
        public string PaymentReferenceNo { get; set; }
    }
}
