using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class OpeningApplication
    {
        public int OpeningApplicationId { get; set; }
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
        public bool? EstablishmentState { get; set; }
        public bool? OfficerState { get; set; }
        public bool? IsActive { get; set; }
    }
}
