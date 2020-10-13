using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class CasesTransfer
    {
        public int CaseTransferId { get; set; }
        public int? CaseId { get; set; }
        public string CaseNumber { get; set; }
        public string CaseType { get; set; }
        public int? AmendmentTypeId { get; set; }
        public string AmendmentTypeRemark { get; set; }
        public string AmendmentTypeRemark2 { get; set; }
        public string CaseState { get; set; }
        public int? EstablishmentId { get; set; }
        public int? FromOfficerId { get; set; }
        public string FromOfficerName { get; set; }
        public string FromOfficerPosition { get; set; }
        public string FromOfficerNumber { get; set; }
        public string FromSsbOfficeCode { get; set; }
        public string FromSsbTownshipCode { get; set; }
        public string FromSsbRegionCode { get; set; }
        public int? UserId { get; set; }
        public string Signature { get; set; }
        public DateTime? InternalTransferDate { get; set; }
        public TimeSpan? InternalTransferTime { get; set; }
        public int? ToOfficerId { get; set; }
        public string ToOfficerName { get; set; }
        public string ToOfficerPosition { get; set; }
        public string ToOfficerNumber { get; set; }
        public string ToSsbOfficeCode { get; set; }
        public string ToSsbTownshipCode { get; set; }
        public string ToSsbRegionCode { get; set; }
        public DateTime? InternalStartDate { get; set; }
        public TimeSpan? InternalStartTime { get; set; }
        public DateTime? InternalEndDate { get; set; }
        public TimeSpan? InternalEndTime { get; set; }
        public bool? IsLock { get; set; }
        public string FromOfficerDecision { get; set; }
        public string FromOfficerRemark { get; set; }
        public string ToOfficerDecision { get; set; }
        public string ToOfficerRemark { get; set; }
    }
}
