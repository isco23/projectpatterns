using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class MpuResponse
    {
        public int Id { get; set; }
        public string MerchantId { get; set; }
        public string RespCode { get; set; }
        public string Pan { get; set; }
        public string Amount { get; set; }
        public string InvoiceNo { get; set; }
        public string TranRef { get; set; }
        public string ApprovalCode { get; set; }
        public string DateTime { get; set; }
        public string Status { get; set; }
        public string FailReason { get; set; }
        public string UserDefined1 { get; set; }
        public string UserDefined2 { get; set; }
        public string UserDefined3 { get; set; }
        public string CategoryCode { get; set; }
        public string HashValue { get; set; }
    }
}
