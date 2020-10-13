using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class OfficerHistory
    {
        public int OfficerHistoryId { get; set; }
        public int? OfficerId { get; set; }
        public string OfficerName { get; set; }
        public string OfficerPosition { get; set; }
        public string OfficerNumber { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbTownshipCode { get; set; }
        public string SsbRegionCode { get; set; }
        public int? UserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public TimeSpan? UpdatedTime { get; set; }
        public int? UpdatedUser { get; set; }
    }
}
