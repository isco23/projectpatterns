using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class EmployeePayment
    {
        public int Tranid { get; set; }
        public int? EstablishmentId { get; set; }
        public string EstablishmentNo { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeNameMyanmar { get; set; }
        public string EmployeeNameEnglish { get; set; }
        public string Ssn { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? Salary { get; set; }
        public string Currency { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? ConvertedSalary { get; set; }
        public decimal? Law1EstablishmentPayment { get; set; }
        public decimal? Law1EmployeePayment { get; set; }
        public decimal? Law1Total { get; set; }
        public decimal? Law2EstablishmentPayment { get; set; }
        public decimal? Law2EmployeePayment { get; set; }
        public decimal? Law2Total { get; set; }
        public decimal? EstablishmentTotal { get; set; }
        public decimal? EmployeeTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? Law1Penalty { get; set; }
        public decimal? Law2Penalty { get; set; }
        public decimal? PenaltyTotal { get; set; }
        public decimal? NetAmount { get; set; }
        public string Remark { get; set; }
        public string ReferenceNumber { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbInvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public bool? IsAdditionalUnPaid { get; set; }
        public bool? IsPaid { get; set; }
    }
}
