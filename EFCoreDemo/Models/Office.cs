using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Office
    {
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
        public string OfficeEmail { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbTownshipCode { get; set; }
        public string SsbRegionCode { get; set; }
        public string SrPcode { get; set; }
        public string TownshipPcode { get; set; }
        public string SsbBankAccount { get; set; }
        public string SsbBankName { get; set; }
        public int? LastEstSsn { get; set; }
        public int? LastEmpSsn { get; set; }
        public int? LastCaseNo { get; set; }
        public int? LastInvoiceNo { get; set; }
        public int? LastReceiptNo { get; set; }
        public bool? IsActive { get; set; }
    }
}
