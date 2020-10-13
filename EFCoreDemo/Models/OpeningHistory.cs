using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class OpeningHistory
    {
        public int OpeningHistoryId { get; set; }
        public string EstablishmentNameMyanmar { get; set; }
        public string EstablishmentNameEnglish { get; set; }
        public string EstablishmentType { get; set; }
        public string BuildingArea { get; set; }
        public string LandArea { get; set; }
        public string EstablishmentAddressNumber { get; set; }
        public string EstablishmentStreet { get; set; }
        public string EstablishmentWard { get; set; }
        public string EstablishmentTownship { get; set; }
        public string EstablishmentRegion { get; set; }
        public string OwnerNameMyanmar { get; set; }
        public string OwnerNameEnglish { get; set; }
        public string LicenseNo { get; set; }
        public DateTime? AllowanceDate { get; set; }
        public DateTime? CommencingDate { get; set; }
        public int? UserId { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbTownshipCode { get; set; }
        public string SsbRegionCode { get; set; }
        public string SsbYear { get; set; }
        public int? OfficerId { get; set; }
        public string OfficerName { get; set; }
        public string OfficerPosition { get; set; }
        public string OfficerNumber { get; set; }
        public int? EstablishmentId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public TimeSpan? UpdatedTime { get; set; }
        public int? UpdatedUser { get; set; }
    }
}
