using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Cases
    {
        public int CaseId { get; set; }
        public string CaseNumber { get; set; }
        public string CaseType { get; set; }
        public int? AmendmentTypeId { get; set; }
        public string AmendmentTypeRemark { get; set; }
        public string AmendmentTypeRemark2 { get; set; }
        public string CaseState { get; set; }
        public int? EstablishmentId { get; set; }
        public int? OfficerId { get; set; }
        public string OfficerName { get; set; }
        public string OfficerPosition { get; set; }
        public string OfficerNumber { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbTownshipCode { get; set; }
        public string SsbRegionCode { get; set; }
        public int? UserId { get; set; }
        public string Signature { get; set; }
        public DateTime? CaseStartDate { get; set; }
        public string CaseStartTime { get; set; }
        public DateTime? CaseEndDate { get; set; }
        public string CaseEndTime { get; set; }
        public bool? IsLock { get; set; }
        public string OfficerDecision { get; set; }
        public string OfficerRemark { get; set; }
        public string Designation { get; set; }
    }
}
