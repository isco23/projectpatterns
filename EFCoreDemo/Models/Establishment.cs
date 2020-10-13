using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Establishment
    {
        public int EstablishmentId { get; set; }
        public string EstablishmentNameMyanmar { get; set; }
        public string EstablishmentNameEnglish { get; set; }
        public string MyCoRegistrationNumber { get; set; }
        public DateTime? MyCoRegistrationDate { get; set; }
        public string OtherRegistrationNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public int? BankId { get; set; }
        public string TinNumber { get; set; }
        public DateTime? EstablishmentStartDate { get; set; }
        public string EstablishmentAddressNumber { get; set; }
        public string EstablishmentStreet { get; set; }
        public string EstablishmentWard { get; set; }
        public string EstablishmentTownship { get; set; }
        public string EstablishmentRegion { get; set; }
        public string EstablishmentPhone { get; set; }
        public string EstablishmentFax { get; set; }
        public string EstablishmentWebsite { get; set; }
        public string EstablishmentEmail { get; set; }
        public string EstablishmentTypeL1 { get; set; }
        public string EstablishmentTypeL2 { get; set; }
        public string EstablishmentTypeCode { get; set; }
        public string OtherEstablishmentType { get; set; }
        public string OwnershipType { get; set; }
        public bool? PrivateClinic { get; set; }
        public int? EmployeeCount { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string EstablishmentNo { get; set; }
        public string OwnerHonorificMyanmar { get; set; }
        public string OwnerHonorificEnglish { get; set; }
        public string OwnerNameMyanmar { get; set; }
        public string OwnerNameEnglish { get; set; }
        public byte? OwnerGender { get; set; }
        public string OwnerNrcSr { get; set; }
        public string OwnerNrcTownship { get; set; }
        public string OwnerNrcType { get; set; }
        public string OwnerNrcNo { get; set; }
        public string OwnerPassport { get; set; }
        public string OwnerNationality { get; set; }
        public string OwnerAddressNumber { get; set; }
        public string OwnerAddressStreet { get; set; }
        public string OwnerAddressWard { get; set; }
        public string OwnerTownship { get; set; }
        public string OwnerRegion { get; set; }
        public string OwnerPhone { get; set; }
        public string InchargeHonorificMyanmar { get; set; }
        public string InchargeHonorificEnglish { get; set; }
        public string InChargeNameMyanmar { get; set; }
        public string InChargeNameEnglish { get; set; }
        public byte? InChargeGender { get; set; }
        public string InChargeNrcSr { get; set; }
        public string InChargeNrcTownship { get; set; }
        public string InChargeNrcType { get; set; }
        public string InChargeNrcNo { get; set; }
        public string InChargePassport { get; set; }
        public string InchargeNationality { get; set; }
        public string InChargeAddressNumber { get; set; }
        public string InChargeAddressStreet { get; set; }
        public string InChargeAddressWard { get; set; }
        public string InChargeTownship { get; set; }
        public string InChargeRegion { get; set; }
        public string InChargePhone { get; set; }
        public int? UserId { get; set; }
        public string SsbOfficeName { get; set; }
        public string SsbOfficeCode { get; set; }
        public string SsbTownshipCode { get; set; }
        public string SsbRegionCode { get; set; }
        public string SsbYear { get; set; }
        public int? OfficerId { get; set; }
        public string OfficerName { get; set; }
        public string OfficerPosition { get; set; }
        public string OfficerNumber { get; set; }
        public bool? IsActive { get; set; }
        public string UnitLevelInfo { get; set; }
        public string StreetInfo { get; set; }
        public string TownshipInfo { get; set; }
        public string RegionInfo { get; set; }
    }
}
