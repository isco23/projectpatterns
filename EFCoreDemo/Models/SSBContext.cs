using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class SSBContext : DbContext
    {
        public SSBContext()
        {
        }

        public SSBContext(DbContextOptions<SSBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AmendmentHistory> AmendmentHistory { get; set; }
        public virtual DbSet<AmendmentType> AmendmentType { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankApi> BankApi { get; set; }
        public virtual DbSet<BankLogs> BankLogs { get; set; }
        public virtual DbSet<CalendarControl> CalendarControl { get; set; }
        public virtual DbSet<Cases> Cases { get; set; }
        public virtual DbSet<CasesHistory> CasesHistory { get; set; }
        public virtual DbSet<CasesTransfer> CasesTransfer { get; set; }
        public virtual DbSet<CashInOut> CashInOut { get; set; }
        public virtual DbSet<CbmnetCsv> CbmnetCsv { get; set; }
        public virtual DbSet<CbmnetCsvApproved> CbmnetCsvApproved { get; set; }
        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<DbErrors> DbErrors { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<EmailNoti> EmailNoti { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeApplication> EmployeeApplication { get; set; }
        public virtual DbSet<EmployeeDesignation> EmployeeDesignation { get; set; }
        public virtual DbSet<EmployeeHistory> EmployeeHistory { get; set; }
        public virtual DbSet<EmployeePayment> EmployeePayment { get; set; }
        public virtual DbSet<EmployeeUpload> EmployeeUpload { get; set; }
        public virtual DbSet<Establishment> Establishment { get; set; }
        public virtual DbSet<EstablishmentApplication> EstablishmentApplication { get; set; }
        public virtual DbSet<EstablishmentHistory> EstablishmentHistory { get; set; }
        public virtual DbSet<EstablishmentHistoryNew> EstablishmentHistoryNew { get; set; }
        public virtual DbSet<EstablishmentPayment> EstablishmentPayment { get; set; }
        public virtual DbSet<EstablishmentType> EstablishmentType { get; set; }
        public virtual DbSet<EstablishmentUpload> EstablishmentUpload { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRate { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<GeneralPayment> GeneralPayment { get; set; }
        public virtual DbSet<GeneralPaymentType> GeneralPaymentType { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobHistory> JobHistory { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<Law> Law { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<MpuLog> MpuLog { get; set; }
        public virtual DbSet<MpuResponse> MpuResponse { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<NotificationHistory> NotificationHistory { get; set; }
        public virtual DbSet<NrcSr> NrcSr { get; set; }
        public virtual DbSet<NrcTownship> NrcTownship { get; set; }
        public virtual DbSet<NrcType> NrcType { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<Officer> Officer { get; set; }
        public virtual DbSet<OfficerHistory> OfficerHistory { get; set; }
        public virtual DbSet<OfficerPosition> OfficerPosition { get; set; }
        public virtual DbSet<Opening> Opening { get; set; }
        public virtual DbSet<OpeningApplication> OpeningApplication { get; set; }
        public virtual DbSet<OpeningHistory> OpeningHistory { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<OwnershipType> OwnershipType { get; set; }
        public virtual DbSet<Relationship> Relationship { get; set; }
        public virtual DbSet<SalaryHistory> SalaryHistory { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<Sr> Sr { get; set; }
        public virtual DbSet<SsbReceiptLog> SsbReceiptLog { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<SystemSetting> SystemSetting { get; set; }
        public virtual DbSet<TempEstablishmentApplication> TempEstablishmentApplication { get; set; }
        public virtual DbSet<TmpCsvData> TmpCsvData { get; set; }
        public virtual DbSet<TmpEmployeePayment> TmpEmployeePayment { get; set; }
        public virtual DbSet<TmpEstablishmentPayment> TmpEstablishmentPayment { get; set; }
        public virtual DbSet<TmpJsonData> TmpJsonData { get; set; }
        public virtual DbSet<TmpPenaltyAllEstablishment> TmpPenaltyAllEstablishment { get; set; }
        public virtual DbSet<TmpPenaltyByEstablishment> TmpPenaltyByEstablishment { get; set; }
        public virtual DbSet<Township> Township { get; set; }
        public virtual DbSet<Tranid> Tranid { get; set; }
        public virtual DbSet<TranidLog> TranidLog { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersLevel> UsersLevel { get; set; }
        public virtual DbSet<UsersPermission> UsersPermission { get; set; }
        public virtual DbSet<Ward> Ward { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=SSB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AmendmentHistory>(entity =>
            {
                entity.ToTable("Amendment_History");

                entity.Property(e => e.AmendmentHistoryId).HasColumnName("Amendment_History_Id");

                entity.Property(e => e.AmendmentTypeDate)
                    .HasColumnName("AmendmentType_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeName)
                    .HasColumnName("AmendmentType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BankId).HasColumnName("Bank_Id");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentEmail)
                    .HasColumnName("Establishment_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentFax)
                    .HasColumnName("Establishment_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentPhone)
                    .HasColumnName("Establishment_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentStartDate)
                    .HasColumnName("Establishment_Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentTypeCode)
                    .HasColumnName("Establishment_Type_Code")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentTypeL1)
                    .HasColumnName("Establishment_Type_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentTypeL2)
                    .HasColumnName("Establishment_Type_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.EstablishmentWebsite)
                    .HasColumnName("Establishment_Website")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeAddressNumber).HasColumnName("InCharge_Address_Number");

                entity.Property(e => e.InChargeAddressStreet).HasColumnName("InCharge_Address_Street");

                entity.Property(e => e.InChargeAddressWard).HasColumnName("InCharge_Address_Ward");

                entity.Property(e => e.InChargeGender).HasColumnName("InCharge_Gender");

                entity.Property(e => e.InChargeNameEnglish)
                    .HasColumnName("InCharge_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNameMyanmar)
                    .HasColumnName("InCharge_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNrcNo)
                    .HasColumnName("InCharge_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcSr)
                    .HasColumnName("InCharge_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcTownship)
                    .HasColumnName("InCharge_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcType)
                    .HasColumnName("InCharge_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargePassport)
                    .HasColumnName("InCharge_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargePhone)
                    .HasColumnName("InCharge_Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeRegion)
                    .HasColumnName("InCharge_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeTownship)
                    .HasColumnName("InCharge_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.InchargeHonorificEnglish)
                    .HasColumnName("Incharge_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeHonorificMyanmar)
                    .HasColumnName("Incharge_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeNationality)
                    .HasColumnName("Incharge_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.MyCoRegistrationDate)
                    .HasColumnName("MyCo_Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MyCoRegistrationNumber)
                    .HasColumnName("MyCo_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherEstablishmentType)
                    .HasColumnName("Other_Establishment_Type")
                    .HasMaxLength(500);

                entity.Property(e => e.OtherRegistrationNumber)
                    .HasColumnName("Other_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerAddressNumber).HasColumnName("Owner_Address_Number");

                entity.Property(e => e.OwnerAddressStreet).HasColumnName("Owner_Address_Street");

                entity.Property(e => e.OwnerAddressWard).HasColumnName("Owner_Address_Ward");

                entity.Property(e => e.OwnerGender).HasColumnName("Owner_Gender");

                entity.Property(e => e.OwnerHonorificEnglish)
                    .HasColumnName("Owner_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerHonorificMyanmar)
                    .HasColumnName("Owner_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNationality)
                    .HasColumnName("Owner_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNrcNo)
                    .HasColumnName("Owner_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcSr)
                    .HasColumnName("Owner_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcTownship)
                    .HasColumnName("Owner_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcType)
                    .HasColumnName("Owner_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerPassport)
                    .HasColumnName("Owner_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerPhone)
                    .HasColumnName("Owner_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerRegion)
                    .HasColumnName("Owner_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerTownship)
                    .HasColumnName("Owner_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnershipType)
                    .HasColumnName("Ownership_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbYear)
                    .HasColumnName("SSB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.TinNumber)
                    .HasColumnName("TIN_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<AmendmentType>(entity =>
            {
                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeName)
                    .HasColumnName("AmendmentType_Name")
                    .HasMaxLength(1000);

                entity.Property(e => e.Owner).HasMaxLength(100);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.BankId).HasColumnName("Bank_Id");

                entity.Property(e => e.BankName)
                    .HasColumnName("Bank_Name")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<BankApi>(entity =>
            {
                entity.ToTable("Bank_API");

                entity.Property(e => e.BankApiId).HasColumnName("Bank_API_Id");

                entity.Property(e => e.BankApiKey)
                    .HasColumnName("Bank_API_Key")
                    .HasMaxLength(50);

                entity.Property(e => e.BankName)
                    .HasColumnName("Bank_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<BankLogs>(entity =>
            {
                entity.ToTable("Bank_Logs");

                entity.Property(e => e.BankChannel)
                    .HasColumnName("Bank_Channel")
                    .HasMaxLength(300);

                entity.Property(e => e.IsSuccess)
                    .HasColumnName("isSuccess")
                    .HasMaxLength(100);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.TotalAmount).HasMaxLength(1000);

                entity.Property(e => e.UpdatedTime).HasMaxLength(100);
            });

            modelBuilder.Entity<CalendarControl>(entity =>
            {
                entity.HasKey(e => e.CalendarId);

                entity.ToTable("Calendar_Control");

                entity.Property(e => e.CalendarId).HasColumnName("Calendar_Id");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentName)
                    .HasColumnName("Establishment_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(50);

                entity.Property(e => e.IsEnable).HasColumnName("Is_Enable");

                entity.Property(e => e.Month).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<Cases>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.Property(e => e.CaseId).HasColumnName("Case_Id");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.CaseEndDate)
                    .HasColumnName("Case_EndDate")
                    .HasColumnType("date");

                entity.Property(e => e.CaseEndTime)
                    .HasColumnName("Case_EndTime")
                    .HasMaxLength(50);

                entity.Property(e => e.CaseNumber)
                    .HasColumnName("Case_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseStartDate)
                    .HasColumnName("Case_StartDate")
                    .HasColumnType("date");

                entity.Property(e => e.CaseStartTime)
                    .HasColumnName("Case_StartTime")
                    .HasMaxLength(50);

                entity.Property(e => e.CaseState)
                    .HasColumnName("Case_State")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseType)
                    .HasColumnName("Case_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.OfficerDecision)
                    .HasColumnName("Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerRemark)
                    .HasColumnName("Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Signature).HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<CasesHistory>(entity =>
            {
                entity.HasKey(e => e.CaseHistoryId)
                    .HasName("PK_Case_History");

                entity.ToTable("Cases_History");

                entity.Property(e => e.CaseHistoryId).HasColumnName("CaseHistory_Id");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.CaseEndDate)
                    .HasColumnName("Case_EndDate")
                    .HasColumnType("date");

                entity.Property(e => e.CaseEndTime)
                    .HasColumnName("Case_EndTime")
                    .HasMaxLength(50);

                entity.Property(e => e.CaseId).HasColumnName("Case_Id");

                entity.Property(e => e.CaseNumber)
                    .HasColumnName("Case_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseStartDate)
                    .HasColumnName("Case_StartDate")
                    .HasColumnType("date");

                entity.Property(e => e.CaseStartTime)
                    .HasColumnName("Case_StartTime")
                    .HasMaxLength(50);

                entity.Property(e => e.CaseState)
                    .HasColumnName("Case_State")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseType)
                    .HasColumnName("Case_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.EstablishmentHistoryId).HasColumnName("Establishment_History_Id");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.OfficerDecision)
                    .HasColumnName("Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerRemark)
                    .HasColumnName("Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Signature).HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<CasesTransfer>(entity =>
            {
                entity.HasKey(e => e.CaseTransferId);

                entity.ToTable("Cases_Transfer");

                entity.Property(e => e.CaseTransferId).HasColumnName("CaseTransfer_Id");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.CaseId).HasColumnName("Case_Id");

                entity.Property(e => e.CaseNumber)
                    .HasColumnName("Case_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseState)
                    .HasColumnName("Case_State")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseType)
                    .HasColumnName("Case_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.FromOfficerDecision)
                    .HasColumnName("From_Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.FromOfficerId).HasColumnName("From_Officer_Id");

                entity.Property(e => e.FromOfficerName)
                    .HasColumnName("From_Officer_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FromOfficerNumber)
                    .HasColumnName("From_Officer_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.FromOfficerPosition)
                    .HasColumnName("From_Officer_Position")
                    .HasMaxLength(100);

                entity.Property(e => e.FromOfficerRemark)
                    .HasColumnName("From_Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.FromSsbOfficeCode)
                    .HasColumnName("From_SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.FromSsbRegionCode)
                    .HasColumnName("From_SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.FromSsbTownshipCode)
                    .HasColumnName("From_SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.InternalEndDate)
                    .HasColumnName("Internal_EndDate")
                    .HasColumnType("date");

                entity.Property(e => e.InternalEndTime).HasColumnName("Internal_EndTime");

                entity.Property(e => e.InternalStartDate)
                    .HasColumnName("Internal_StartDate")
                    .HasColumnType("date");

                entity.Property(e => e.InternalStartTime).HasColumnName("Internal_StartTime");

                entity.Property(e => e.InternalTransferDate)
                    .HasColumnName("Internal_TransferDate")
                    .HasColumnType("date");

                entity.Property(e => e.InternalTransferTime).HasColumnName("Internal_TransferTime");

                entity.Property(e => e.Signature).HasMaxLength(100);

                entity.Property(e => e.ToOfficerDecision)
                    .HasColumnName("To_Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.ToOfficerId).HasColumnName("To_Officer_Id");

                entity.Property(e => e.ToOfficerName)
                    .HasColumnName("To_Officer_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ToOfficerNumber)
                    .HasColumnName("To_Officer_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.ToOfficerPosition)
                    .HasColumnName("To_Officer_Position")
                    .HasMaxLength(100);

                entity.Property(e => e.ToOfficerRemark)
                    .HasColumnName("To_Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.ToSsbOfficeCode)
                    .HasColumnName("To_SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ToSsbRegionCode)
                    .HasColumnName("To_SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ToSsbTownshipCode)
                    .HasColumnName("To_SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<CashInOut>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_Id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BankChannel)
                    .HasColumnName("Bank_Channel")
                    .HasMaxLength(50);

                entity.Property(e => e.ContributionApprovedDate)
                    .HasColumnName("Contribution_Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EstablishmentId)
                    .HasColumnName("Establishment_Id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GeneralPayment)
                    .HasColumnName("General_Payment")
                    .HasMaxLength(50);

                entity.Property(e => e.IsContributionApproved).HasColumnName("Is_Contribution_Approved");

                entity.Property(e => e.IsSuccess)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Month).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentReferenceNo)
                    .HasColumnName("Payment_Reference_No")
                    .HasMaxLength(500);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SsbReceiptNo)
                    .HasColumnName("SSB_Receipt_No")
                    .HasMaxLength(100);

                entity.Property(e => e.Year).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CbmnetCsv>(entity =>
            {
                entity.ToTable("CBMNet_CSV");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.EstablishmentNo)
                    .IsRequired()
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImportDateTime)
                    .HasColumnName("Import_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImportUserId).HasColumnName("Import_User_Id");

                entity.Property(e => e.Path).HasMaxLength(500);

                entity.Property(e => e.ReferenceCode)
                    .IsRequired()
                    .HasColumnName("Reference_Code")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CbmnetCsvApproved>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CBMNet_CSV_Approved");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ApprovedDateTime)
                    .HasColumnName("Approved_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedUserId).HasColumnName("Approved_User_Id");

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.ReferenceCode)
                    .HasColumnName("Reference_Code")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Control>(entity =>
            {
                entity.Property(e => e.ControlId).HasColumnName("Control_Id");

                entity.Property(e => e.ControlName)
                    .HasColumnName("Control_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ControlUrl)
                    .HasColumnName("Control_URL")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key)
                    .HasName("CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DbErrors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DB_Errors");

                entity.Property(e => e.ErrorDateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorId)
                    .HasColumnName("ErrorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.ErrorProcedure).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.DistrictPcode);

                entity.Property(e => e.DistrictPcode)
                    .HasColumnName("District_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("District_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SrPcode)
                    .HasColumnName("SR_Pcode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmailNoti>(entity =>
            {
                entity.ToTable("Email_Noti");

                entity.Property(e => e.EmailNotiId).HasColumnName("Email_Noti_Id");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.NotiType)
                    .HasColumnName("Noti_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerDescription)
                    .HasColumnName("Officer_Description")
                    .HasMaxLength(1000);

                entity.Property(e => e.Subject).HasMaxLength(500);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Child10DobDay)
                    .HasColumnName("Child10_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10DobMonth)
                    .HasColumnName("Child10_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10DobYear)
                    .HasColumnName("Child10_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10Gender).HasColumnName("Child10_Gender");

                entity.Property(e => e.Child10Name)
                    .HasColumnName("Child10_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child1DobDay)
                    .HasColumnName("Child1_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1DobMonth)
                    .HasColumnName("Child1_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1DobYear)
                    .HasColumnName("Child1_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1Gender).HasColumnName("Child1_Gender");

                entity.Property(e => e.Child1Name)
                    .HasColumnName("Child1_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child2DobDay)
                    .HasColumnName("Child2_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2DobMonth)
                    .HasColumnName("Child2_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2DobYear)
                    .HasColumnName("Child2_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2Gender).HasColumnName("Child2_Gender");

                entity.Property(e => e.Child2Name)
                    .HasColumnName("Child2_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child3DobDay)
                    .HasColumnName("Child3_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3DobMonth)
                    .HasColumnName("Child3_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3DobYear)
                    .HasColumnName("Child3_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3Gender).HasColumnName("Child3_Gender");

                entity.Property(e => e.Child3Name)
                    .HasColumnName("Child3_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child4DobDay)
                    .HasColumnName("Child4_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4DobMonth)
                    .HasColumnName("Child4_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4DobYear)
                    .HasColumnName("Child4_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4Gender).HasColumnName("Child4_Gender");

                entity.Property(e => e.Child4Name)
                    .HasColumnName("Child4_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child5DobDay)
                    .HasColumnName("Child5_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5DobMonth)
                    .HasColumnName("Child5_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5DobYear)
                    .HasColumnName("Child5_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5Gender).HasColumnName("Child5_Gender");

                entity.Property(e => e.Child5Name)
                    .HasColumnName("Child5_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child6DobDay)
                    .HasColumnName("Child6_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6DobMonth)
                    .HasColumnName("Child6_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6DobYear)
                    .HasColumnName("Child6_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6Gender).HasColumnName("Child6_Gender");

                entity.Property(e => e.Child6Name)
                    .HasColumnName("Child6_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child7DobDay)
                    .HasColumnName("Child7_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7DobMonth)
                    .HasColumnName("Child7_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7DobYear)
                    .HasColumnName("Child7_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7Gender).HasColumnName("Child7_Gender");

                entity.Property(e => e.Child7Name)
                    .HasColumnName("Child7_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child8DobDay)
                    .HasColumnName("Child8_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8DobMonth)
                    .HasColumnName("Child8_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8DobYear)
                    .HasColumnName("Child8_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8Gender).HasColumnName("Child8_Gender");

                entity.Property(e => e.Child8Name)
                    .HasColumnName("Child8_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child9DobDay)
                    .HasColumnName("Child9_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9DobMonth)
                    .HasColumnName("Child9_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9DobYear)
                    .HasColumnName("Child9_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9Gender).HasColumnName("Child9_Gender");

                entity.Property(e => e.Child9Name)
                    .HasColumnName("Child9_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EffectiveDay).HasColumnName("Effective_Day");

                entity.Property(e => e.EffectiveMonth).HasColumnName("Effective_Month");

                entity.Property(e => e.EffectiveYear).HasColumnName("Effective_Year");

                entity.Property(e => e.EmployeeAddressNumber).HasColumnName("Employee_Address_Number");

                entity.Property(e => e.EmployeeDesignationCode)
                    .HasColumnName("Employee_Designation_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL1)
                    .HasColumnName("Employee_Designation_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL2)
                    .HasColumnName("Employee_Designation_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL3)
                    .HasColumnName("Employee_Designation_L3")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobDay)
                    .HasColumnName("Employee_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobMonth)
                    .HasColumnName("Employee_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobYear)
                    .HasColumnName("Employee_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeEmail)
                    .HasColumnName("Employee_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeFatherName)
                    .HasColumnName("Employee_FatherName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeFax)
                    .HasColumnName("Employee_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeGender).HasColumnName("Employee_Gender");

                entity.Property(e => e.EmployeeMotherName)
                    .HasColumnName("Employee_MotherName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeNameEnglish)
                    .HasColumnName("Employee_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNameMyanmar)
                    .HasColumnName("Employee_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNationalityId).HasColumnName("Employee_Nationality_Id");

                entity.Property(e => e.EmployeeNrcNo)
                    .HasColumnName("Employee_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNrcSr)
                    .HasColumnName("Employee_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNrcTownship)
                    .HasColumnName("Employee_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNrcType)
                    .HasColumnName("Employee_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeePassport)
                    .HasColumnName("Employee_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeePhone)
                    .HasColumnName("Employee_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeRegion)
                    .HasColumnName("Employee_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeStreet).HasColumnName("Employee_Street");

                entity.Property(e => e.EmployeeTownship)
                    .HasColumnName("Employee_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeWard).HasColumnName("Employee_Ward");

                entity.Property(e => e.EstablishmentName)
                    .HasColumnName("Establishment_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.HonorificEnglish)
                    .HasColumnName("Honorific_English")
                    .HasMaxLength(10);

                entity.Property(e => e.HonorificMyanmar)
                    .HasColumnName("Honorific_Myanmar")
                    .HasMaxLength(10);

                entity.Property(e => e.IncomeType).HasMaxLength(50);

                entity.Property(e => e.JoinedDay)
                    .HasColumnName("Joined_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.JoinedMonth)
                    .HasColumnName("Joined_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.JoinedYear)
                    .HasColumnName("Joined_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.LeaveDate)
                    .HasColumnName("Leave_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveRemark).HasMaxLength(1000);

                entity.Property(e => e.MaritalStatusType).HasColumnName("MaritalStatus_Type");

                entity.Property(e => e.Nominee10DobDay)
                    .HasColumnName("Nominee10_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10DobMonth)
                    .HasColumnName("Nominee10_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10DobYear)
                    .HasColumnName("Nominee10_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10Gender)
                    .HasColumnName("Nominee10_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee10HonorificMyanmar)
                    .HasColumnName("Nominee10_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10Name)
                    .HasColumnName("Nominee10_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee10Relationship)
                    .HasColumnName("Nominee10_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1DobDay)
                    .HasColumnName("Nominee1_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1DobMonth)
                    .HasColumnName("Nominee1_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1DobYear)
                    .HasColumnName("Nominee1_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1Gender)
                    .HasColumnName("Nominee1_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1HonorificMyanmar)
                    .HasColumnName("Nominee1_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1Name)
                    .HasColumnName("Nominee1_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1Relationship)
                    .HasColumnName("Nominee1_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2DobDay)
                    .HasColumnName("Nominee2_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2DobMonth)
                    .HasColumnName("Nominee2_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2DobYear)
                    .HasColumnName("Nominee2_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2Gender)
                    .HasColumnName("Nominee2_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2HonorificMyanmar)
                    .HasColumnName("Nominee2_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2Name)
                    .HasColumnName("Nominee2_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2Relationship)
                    .HasColumnName("Nominee2_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3DobDay)
                    .HasColumnName("Nominee3_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3DobMonth)
                    .HasColumnName("Nominee3_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3DobYear)
                    .HasColumnName("Nominee3_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3Gender)
                    .HasColumnName("Nominee3_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3HonorificMyanmar)
                    .HasColumnName("Nominee3_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3Name)
                    .HasColumnName("Nominee3_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3Relationship)
                    .HasColumnName("Nominee3_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4DobDay)
                    .HasColumnName("Nominee4_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4DobMonth)
                    .HasColumnName("Nominee4_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4DobYear)
                    .HasColumnName("Nominee4_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4Gender)
                    .HasColumnName("Nominee4_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4HonorificMyanmar)
                    .HasColumnName("Nominee4_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4Name)
                    .HasColumnName("Nominee4_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4Relationship)
                    .HasColumnName("Nominee4_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5DobDay)
                    .HasColumnName("Nominee5_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5DobMonth)
                    .HasColumnName("Nominee5_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5DobYear)
                    .HasColumnName("Nominee5_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5Gender)
                    .HasColumnName("Nominee5_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5HonorificMyanmar)
                    .HasColumnName("Nominee5_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5Name)
                    .HasColumnName("Nominee5_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5Relationship)
                    .HasColumnName("Nominee5_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6DobDay)
                    .HasColumnName("Nominee6_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6DobMonth)
                    .HasColumnName("Nominee6_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6DobYear)
                    .HasColumnName("Nominee6_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6Gender)
                    .HasColumnName("Nominee6_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6HonorificMyanmar)
                    .HasColumnName("Nominee6_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6Name)
                    .HasColumnName("Nominee6_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6Relationship)
                    .HasColumnName("Nominee6_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7DobDay)
                    .HasColumnName("Nominee7_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7DobMonth)
                    .HasColumnName("Nominee7_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7DobYear)
                    .HasColumnName("Nominee7_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7Gender)
                    .HasColumnName("Nominee7_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7HonorificMyanmar)
                    .HasColumnName("Nominee7_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7Name)
                    .HasColumnName("Nominee7_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7Relationship)
                    .HasColumnName("Nominee7_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8DobDay)
                    .HasColumnName("Nominee8_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8DobMonth)
                    .HasColumnName("Nominee8_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8DobYear)
                    .HasColumnName("Nominee8_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8Gender)
                    .HasColumnName("Nominee8_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8HonorificMyanmar)
                    .HasColumnName("Nominee8_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8Name)
                    .HasColumnName("Nominee8_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8Relationship)
                    .HasColumnName("Nominee8_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9DobDay)
                    .HasColumnName("Nominee9_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9DobMonth)
                    .HasColumnName("Nominee9_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9DobYear)
                    .HasColumnName("Nominee9_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9Gender)
                    .HasColumnName("Nominee9_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9HonorificMyanmar)
                    .HasColumnName("Nominee9_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9Name)
                    .HasColumnName("Nominee9_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9Relationship)
                    .HasColumnName("Nominee9_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherDesignation)
                    .HasColumnName("Other_Designation")
                    .HasMaxLength(500);

                entity.Property(e => e.PermanentAddressNumber).HasColumnName("Permanent_Address_Number");

                entity.Property(e => e.PermanentRegion)
                    .HasColumnName("Permanent_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.PermanentStreet).HasColumnName("Permanent_Street");

                entity.Property(e => e.PermanentTownship)
                    .HasColumnName("Permanent_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.PermanentWard).HasColumnName("Permanent_Ward");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.Property(e => e.SpouseDobDay)
                    .HasColumnName("Spouse_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseDobMonth)
                    .HasColumnName("Spouse_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseDobYear)
                    .HasColumnName("Spouse_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseHonorificMyanmar)
                    .HasColumnName("Spouse_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("Spouse_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbYear)
                    .HasColumnName("SSB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssn)
                    .IsRequired()
                    .HasColumnName("SSN")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<EmployeeApplication>(entity =>
            {
                entity.ToTable("Employee_Application");

                entity.Property(e => e.EmployeeApplicationId).HasColumnName("Employee_Application_Id");

                entity.Property(e => e.AmendmentTypeDate)
                    .HasColumnName("AmendmentType_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeName)
                    .HasColumnName("AmendmentType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Child10DobDay)
                    .HasColumnName("Child10_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10DobMonth)
                    .HasColumnName("Child10_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10DobYear)
                    .HasColumnName("Child10_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10Gender).HasColumnName("Child10_Gender");

                entity.Property(e => e.Child10Name)
                    .HasColumnName("Child10_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child1DobDay)
                    .HasColumnName("Child1_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1DobMonth)
                    .HasColumnName("Child1_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1DobYear)
                    .HasColumnName("Child1_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1Gender).HasColumnName("Child1_Gender");

                entity.Property(e => e.Child1Name)
                    .HasColumnName("Child1_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child2DobDay)
                    .HasColumnName("Child2_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2DobMonth)
                    .HasColumnName("Child2_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2DobYear)
                    .HasColumnName("Child2_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2Gender).HasColumnName("Child2_Gender");

                entity.Property(e => e.Child2Name)
                    .HasColumnName("Child2_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child3DobDay)
                    .HasColumnName("Child3_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3DobMonth)
                    .HasColumnName("Child3_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3DobYear)
                    .HasColumnName("Child3_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3Gender).HasColumnName("Child3_Gender");

                entity.Property(e => e.Child3Name)
                    .HasColumnName("Child3_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child4DobDay)
                    .HasColumnName("Child4_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4DobMonth)
                    .HasColumnName("Child4_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4DobYear)
                    .HasColumnName("Child4_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4Gender).HasColumnName("Child4_Gender");

                entity.Property(e => e.Child4Name)
                    .HasColumnName("Child4_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child5DobDay)
                    .HasColumnName("Child5_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5DobMonth)
                    .HasColumnName("Child5_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5DobYear)
                    .HasColumnName("Child5_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5Gender).HasColumnName("Child5_Gender");

                entity.Property(e => e.Child5Name)
                    .HasColumnName("Child5_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child6DobDay)
                    .HasColumnName("Child6_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6DobMonth)
                    .HasColumnName("Child6_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6DobYear)
                    .HasColumnName("Child6_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6Gender).HasColumnName("Child6_Gender");

                entity.Property(e => e.Child6Name)
                    .HasColumnName("Child6_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child7DobDay)
                    .HasColumnName("Child7_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7DobMonth)
                    .HasColumnName("Child7_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7DobYear)
                    .HasColumnName("Child7_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7Gender).HasColumnName("Child7_Gender");

                entity.Property(e => e.Child7Name)
                    .HasColumnName("Child7_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child8DobDay)
                    .HasColumnName("Child8_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8DobMonth)
                    .HasColumnName("Child8_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8DobYear)
                    .HasColumnName("Child8_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8Gender).HasColumnName("Child8_Gender");

                entity.Property(e => e.Child8Name)
                    .HasColumnName("Child8_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child9DobDay)
                    .HasColumnName("Child9_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9DobMonth)
                    .HasColumnName("Child9_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9DobYear)
                    .HasColumnName("Child9_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9Gender).HasColumnName("Child9_Gender");

                entity.Property(e => e.Child9Name)
                    .HasColumnName("Child9_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.EffectiveDay).HasColumnName("Effective_Day");

                entity.Property(e => e.EffectiveMonth).HasColumnName("Effective_Month");

                entity.Property(e => e.EffectiveYear).HasColumnName("Effective_Year");

                entity.Property(e => e.EmployeeAddressNumber).HasColumnName("Employee_Address_Number");

                entity.Property(e => e.EmployeeDesignationCode)
                    .HasColumnName("Employee_Designation_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL1)
                    .HasColumnName("Employee_Designation_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL2)
                    .HasColumnName("Employee_Designation_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL3)
                    .HasColumnName("Employee_Designation_L3")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobDay)
                    .HasColumnName("Employee_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobMonth)
                    .HasColumnName("Employee_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobYear)
                    .HasColumnName("Employee_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeEmail)
                    .HasColumnName("Employee_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeFatherName)
                    .HasColumnName("Employee_FatherName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeFax)
                    .HasColumnName("Employee_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeGender).HasColumnName("Employee_Gender");

                entity.Property(e => e.EmployeeMotherName)
                    .HasColumnName("Employee_MotherName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeNameEnglish)
                    .HasColumnName("Employee_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNameMyanmar)
                    .HasColumnName("Employee_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNationalityId).HasColumnName("Employee_Nationality_Id");

                entity.Property(e => e.EmployeeNrcNo)
                    .HasColumnName("Employee_NRC_No")
                    .HasMaxLength(20);

                entity.Property(e => e.EmployeeNrcSr)
                    .HasColumnName("Employee_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNrcTownship)
                    .HasColumnName("Employee_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNrcType)
                    .HasColumnName("Employee_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeePassport)
                    .HasColumnName("Employee_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeePhone)
                    .HasColumnName("Employee_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeRegion)
                    .HasColumnName("Employee_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeState).HasColumnName("Employee_State");

                entity.Property(e => e.EmployeeStreet).HasColumnName("Employee_Street");

                entity.Property(e => e.EmployeeTownship)
                    .HasColumnName("Employee_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeWard).HasColumnName("Employee_Ward");

                entity.Property(e => e.EstablishmentName)
                    .HasColumnName("Establishment_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.HonorificEnglish)
                    .HasColumnName("Honorific_English")
                    .HasMaxLength(10);

                entity.Property(e => e.HonorificMyanmar)
                    .HasColumnName("Honorific_Myanmar")
                    .HasMaxLength(10);

                entity.Property(e => e.IncomeType).HasMaxLength(50);

                entity.Property(e => e.JoinedDay)
                    .HasColumnName("Joined_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.JoinedMonth)
                    .HasColumnName("Joined_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.JoinedYear)
                    .HasColumnName("Joined_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.LeaveDate)
                    .HasColumnName("Leave_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveRemark).HasMaxLength(1000);

                entity.Property(e => e.MaritalStatusType).HasColumnName("MaritalStatus_Type");

                entity.Property(e => e.Nominee10DobDay)
                    .HasColumnName("Nominee10_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10DobMonth)
                    .HasColumnName("Nominee10_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10DobYear)
                    .HasColumnName("Nominee10_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10Gender)
                    .HasColumnName("Nominee10_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee10HonorificMyanmar)
                    .HasColumnName("Nominee10_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10Name)
                    .HasColumnName("Nominee10_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee10Relationship)
                    .HasColumnName("Nominee10_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1DobDay)
                    .HasColumnName("Nominee1_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1DobMonth)
                    .HasColumnName("Nominee1_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1DobYear)
                    .HasColumnName("Nominee1_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1Gender)
                    .HasColumnName("Nominee1_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1HonorificMyanmar)
                    .HasColumnName("Nominee1_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1Name)
                    .HasColumnName("Nominee1_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1Relationship)
                    .HasColumnName("Nominee1_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2DobDay)
                    .HasColumnName("Nominee2_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2DobMonth)
                    .HasColumnName("Nominee2_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2DobYear)
                    .HasColumnName("Nominee2_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2Gender)
                    .HasColumnName("Nominee2_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2HonorificMyanmar)
                    .HasColumnName("Nominee2_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2Name)
                    .HasColumnName("Nominee2_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2Relationship)
                    .HasColumnName("Nominee2_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3DobDay)
                    .HasColumnName("Nominee3_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3DobMonth)
                    .HasColumnName("Nominee3_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3DobYear)
                    .HasColumnName("Nominee3_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3Gender)
                    .HasColumnName("Nominee3_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3HonorificMyanmar)
                    .HasColumnName("Nominee3_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3Name)
                    .HasColumnName("Nominee3_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3Relationship)
                    .HasColumnName("Nominee3_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4DobDay)
                    .HasColumnName("Nominee4_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4DobMonth)
                    .HasColumnName("Nominee4_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4DobYear)
                    .HasColumnName("Nominee4_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4Gender)
                    .HasColumnName("Nominee4_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4HonorificMyanmar)
                    .HasColumnName("Nominee4_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4Name)
                    .HasColumnName("Nominee4_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4Relationship)
                    .HasColumnName("Nominee4_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5DobDay)
                    .HasColumnName("Nominee5_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5DobMonth)
                    .HasColumnName("Nominee5_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5DobYear)
                    .HasColumnName("Nominee5_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5Gender)
                    .HasColumnName("Nominee5_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5HonorificMyanmar)
                    .HasColumnName("Nominee5_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5Name)
                    .HasColumnName("Nominee5_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5Relationship)
                    .HasColumnName("Nominee5_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6DobDay)
                    .HasColumnName("Nominee6_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6DobMonth)
                    .HasColumnName("Nominee6_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6DobYear)
                    .HasColumnName("Nominee6_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6Gender)
                    .HasColumnName("Nominee6_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6HonorificMyanmar)
                    .HasColumnName("Nominee6_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6Name)
                    .HasColumnName("Nominee6_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6Relationship)
                    .HasColumnName("Nominee6_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7DobDay)
                    .HasColumnName("Nominee7_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7DobMonth)
                    .HasColumnName("Nominee7_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7DobYear)
                    .HasColumnName("Nominee7_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7Gender)
                    .HasColumnName("Nominee7_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7HonorificMyanmar)
                    .HasColumnName("Nominee7_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7Name)
                    .HasColumnName("Nominee7_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7Relationship)
                    .HasColumnName("Nominee7_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8DobDay)
                    .HasColumnName("Nominee8_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8DobMonth)
                    .HasColumnName("Nominee8_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8DobYear)
                    .HasColumnName("Nominee8_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8Gender)
                    .HasColumnName("Nominee8_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8HonorificMyanmar)
                    .HasColumnName("Nominee8_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8Name)
                    .HasColumnName("Nominee8_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8Relationship)
                    .HasColumnName("Nominee8_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9DobDay)
                    .HasColumnName("Nominee9_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9DobMonth)
                    .HasColumnName("Nominee9_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9DobYear)
                    .HasColumnName("Nominee9_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9Gender)
                    .HasColumnName("Nominee9_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9HonorificMyanmar)
                    .HasColumnName("Nominee9_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9Name)
                    .HasColumnName("Nominee9_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9Relationship)
                    .HasColumnName("Nominee9_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerDecision)
                    .HasColumnName("Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerRemark)
                    .HasColumnName("Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.OfficerState).HasColumnName("Officer_State");

                entity.Property(e => e.OtherDesignation)
                    .HasColumnName("Other_Designation")
                    .HasMaxLength(500);

                entity.Property(e => e.PermanentAddressNumber).HasColumnName("Permanent_Address_Number");

                entity.Property(e => e.PermanentRegion)
                    .HasColumnName("Permanent_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.PermanentStreet).HasColumnName("Permanent_Street");

                entity.Property(e => e.PermanentTownship)
                    .HasColumnName("Permanent_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.PermanentWard).HasColumnName("Permanent_Ward");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.Property(e => e.SpouseDobDay)
                    .HasColumnName("Spouse_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseDobMonth)
                    .HasColumnName("Spouse_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseDobYear)
                    .HasColumnName("Spouse_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseHonorificMyanmar)
                    .HasColumnName("Spouse_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("Spouse_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<EmployeeDesignation>(entity =>
            {
                entity.ToTable("Employee_Designation");

                entity.Property(e => e.EmployeeDesignationId).HasColumnName("Employee_Designation_Id");

                entity.Property(e => e.EmployeeDesignationCode)
                    .HasColumnName("Employee_Designation_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationName)
                    .HasColumnName("Employee_Designation_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.ParentCode)
                    .HasColumnName("Parent_Code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeHistory>(entity =>
            {
                entity.ToTable("Employee_History");

                entity.Property(e => e.EmployeeHistoryId).HasColumnName("Employee_History_Id");

                entity.Property(e => e.AmendmentTypeDate)
                    .HasColumnName("AmendmentType_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeName)
                    .HasColumnName("AmendmentType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Child10DobDay)
                    .HasColumnName("Child10_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10DobMonth)
                    .HasColumnName("Child10_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10DobYear)
                    .HasColumnName("Child10_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child10Gender).HasColumnName("Child10_Gender");

                entity.Property(e => e.Child10Name)
                    .HasColumnName("Child10_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child1DobDay)
                    .HasColumnName("Child1_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1DobMonth)
                    .HasColumnName("Child1_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1DobYear)
                    .HasColumnName("Child1_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child1Gender).HasColumnName("Child1_Gender");

                entity.Property(e => e.Child1Name)
                    .HasColumnName("Child1_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child2DobDay)
                    .HasColumnName("Child2_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2DobMonth)
                    .HasColumnName("Child2_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2DobYear)
                    .HasColumnName("Child2_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child2Gender).HasColumnName("Child2_Gender");

                entity.Property(e => e.Child2Name)
                    .HasColumnName("Child2_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child3DobDay)
                    .HasColumnName("Child3_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3DobMonth)
                    .HasColumnName("Child3_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3DobYear)
                    .HasColumnName("Child3_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child3Gender).HasColumnName("Child3_Gender");

                entity.Property(e => e.Child3Name)
                    .HasColumnName("Child3_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child4DobDay)
                    .HasColumnName("Child4_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4DobMonth)
                    .HasColumnName("Child4_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4DobYear)
                    .HasColumnName("Child4_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child4Gender).HasColumnName("Child4_Gender");

                entity.Property(e => e.Child4Name)
                    .HasColumnName("Child4_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child5DobDay)
                    .HasColumnName("Child5_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5DobMonth)
                    .HasColumnName("Child5_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5DobYear)
                    .HasColumnName("Child5_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child5Gender).HasColumnName("Child5_Gender");

                entity.Property(e => e.Child5Name)
                    .HasColumnName("Child5_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child6DobDay)
                    .HasColumnName("Child6_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6DobMonth)
                    .HasColumnName("Child6_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6DobYear)
                    .HasColumnName("Child6_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child6Gender).HasColumnName("Child6_Gender");

                entity.Property(e => e.Child6Name)
                    .HasColumnName("Child6_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child7DobDay)
                    .HasColumnName("Child7_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7DobMonth)
                    .HasColumnName("Child7_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7DobYear)
                    .HasColumnName("Child7_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child7Gender).HasColumnName("Child7_Gender");

                entity.Property(e => e.Child7Name)
                    .HasColumnName("Child7_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child8DobDay)
                    .HasColumnName("Child8_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8DobMonth)
                    .HasColumnName("Child8_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8DobYear)
                    .HasColumnName("Child8_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child8Gender).HasColumnName("Child8_Gender");

                entity.Property(e => e.Child8Name)
                    .HasColumnName("Child8_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Child9DobDay)
                    .HasColumnName("Child9_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9DobMonth)
                    .HasColumnName("Child9_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9DobYear)
                    .HasColumnName("Child9_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Child9Gender).HasColumnName("Child9_Gender");

                entity.Property(e => e.Child9Name)
                    .HasColumnName("Child9_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.EffectiveDay).HasColumnName("Effective_Day");

                entity.Property(e => e.EffectiveMonth).HasColumnName("Effective_Month");

                entity.Property(e => e.EffectiveYear).HasColumnName("Effective_Year");

                entity.Property(e => e.EmployeeAddressNumber).HasColumnName("Employee_Address_Number");

                entity.Property(e => e.EmployeeDesignationCode)
                    .HasColumnName("Employee_Designation_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL1)
                    .HasColumnName("Employee_Designation_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL2)
                    .HasColumnName("Employee_Designation_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDesignationL3)
                    .HasColumnName("Employee_Designation_L3")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobDay)
                    .HasColumnName("Employee_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobMonth)
                    .HasColumnName("Employee_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeDobYear)
                    .HasColumnName("Employee_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeEmail)
                    .HasColumnName("Employee_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeFatherName)
                    .HasColumnName("Employee_FatherName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeFax)
                    .HasColumnName("Employee_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeGender).HasColumnName("Employee_Gender");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.EmployeeMotherName)
                    .HasColumnName("Employee_MotherName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeNameEnglish)
                    .HasColumnName("Employee_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNameMyanmar)
                    .HasColumnName("Employee_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNationalityId).HasColumnName("Employee_Nationality_Id");

                entity.Property(e => e.EmployeeNrcNo)
                    .HasColumnName("Employee_NRC_No")
                    .HasMaxLength(20);

                entity.Property(e => e.EmployeeNrcSr)
                    .HasColumnName("Employee_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNrcTownship)
                    .HasColumnName("Employee_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNrcType)
                    .HasColumnName("Employee_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeePassport)
                    .HasColumnName("Employee_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeePhone)
                    .HasColumnName("Employee_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeRegion)
                    .HasColumnName("Employee_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeStreet).HasColumnName("Employee_Street");

                entity.Property(e => e.EmployeeTownship)
                    .HasColumnName("Employee_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeWard).HasColumnName("Employee_Ward");

                entity.Property(e => e.EstablishmentName)
                    .HasColumnName("Establishment_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.HonorificEnglish)
                    .HasColumnName("Honorific_English")
                    .HasMaxLength(10);

                entity.Property(e => e.HonorificMyanmar)
                    .HasColumnName("Honorific_Myanmar")
                    .HasMaxLength(10);

                entity.Property(e => e.IncomeType).HasMaxLength(50);

                entity.Property(e => e.JoinedDay)
                    .HasColumnName("Joined_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.JoinedMonth)
                    .HasColumnName("Joined_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.JoinedYear)
                    .HasColumnName("Joined_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.LeaveDate)
                    .HasColumnName("Leave_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveRemark).HasMaxLength(1000);

                entity.Property(e => e.MaritalStatusType).HasColumnName("MaritalStatus_Type");

                entity.Property(e => e.Nominee10DobDay)
                    .HasColumnName("Nominee10_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10DobMonth)
                    .HasColumnName("Nominee10_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10DobYear)
                    .HasColumnName("Nominee10_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10Gender)
                    .HasColumnName("Nominee10_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee10HonorificMyanmar)
                    .HasColumnName("Nominee10_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee10Name)
                    .HasColumnName("Nominee10_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee10Relationship)
                    .HasColumnName("Nominee10_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1DobDay)
                    .HasColumnName("Nominee1_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1DobMonth)
                    .HasColumnName("Nominee1_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1DobYear)
                    .HasColumnName("Nominee1_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1Gender)
                    .HasColumnName("Nominee1_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1HonorificMyanmar)
                    .HasColumnName("Nominee1_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee1Name)
                    .HasColumnName("Nominee1_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee1Relationship)
                    .HasColumnName("Nominee1_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2DobDay)
                    .HasColumnName("Nominee2_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2DobMonth)
                    .HasColumnName("Nominee2_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2DobYear)
                    .HasColumnName("Nominee2_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2Gender)
                    .HasColumnName("Nominee2_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2HonorificMyanmar)
                    .HasColumnName("Nominee2_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee2Name)
                    .HasColumnName("Nominee2_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee2Relationship)
                    .HasColumnName("Nominee2_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3DobDay)
                    .HasColumnName("Nominee3_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3DobMonth)
                    .HasColumnName("Nominee3_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3DobYear)
                    .HasColumnName("Nominee3_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3Gender)
                    .HasColumnName("Nominee3_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3HonorificMyanmar)
                    .HasColumnName("Nominee3_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee3Name)
                    .HasColumnName("Nominee3_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee3Relationship)
                    .HasColumnName("Nominee3_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4DobDay)
                    .HasColumnName("Nominee4_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4DobMonth)
                    .HasColumnName("Nominee4_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4DobYear)
                    .HasColumnName("Nominee4_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4Gender)
                    .HasColumnName("Nominee4_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4HonorificMyanmar)
                    .HasColumnName("Nominee4_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee4Name)
                    .HasColumnName("Nominee4_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee4Relationship)
                    .HasColumnName("Nominee4_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5DobDay)
                    .HasColumnName("Nominee5_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5DobMonth)
                    .HasColumnName("Nominee5_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5DobYear)
                    .HasColumnName("Nominee5_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5Gender)
                    .HasColumnName("Nominee5_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5HonorificMyanmar)
                    .HasColumnName("Nominee5_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee5Name)
                    .HasColumnName("Nominee5_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee5Relationship)
                    .HasColumnName("Nominee5_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6DobDay)
                    .HasColumnName("Nominee6_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6DobMonth)
                    .HasColumnName("Nominee6_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6DobYear)
                    .HasColumnName("Nominee6_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6Gender)
                    .HasColumnName("Nominee6_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6HonorificMyanmar)
                    .HasColumnName("Nominee6_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee6Name)
                    .HasColumnName("Nominee6_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee6Relationship)
                    .HasColumnName("Nominee6_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7DobDay)
                    .HasColumnName("Nominee7_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7DobMonth)
                    .HasColumnName("Nominee7_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7DobYear)
                    .HasColumnName("Nominee7_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7Gender)
                    .HasColumnName("Nominee7_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7HonorificMyanmar)
                    .HasColumnName("Nominee7_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee7Name)
                    .HasColumnName("Nominee7_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee7Relationship)
                    .HasColumnName("Nominee7_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8DobDay)
                    .HasColumnName("Nominee8_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8DobMonth)
                    .HasColumnName("Nominee8_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8DobYear)
                    .HasColumnName("Nominee8_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8Gender)
                    .HasColumnName("Nominee8_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8HonorificMyanmar)
                    .HasColumnName("Nominee8_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee8Name)
                    .HasColumnName("Nominee8_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee8Relationship)
                    .HasColumnName("Nominee8_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9DobDay)
                    .HasColumnName("Nominee9_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9DobMonth)
                    .HasColumnName("Nominee9_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9DobYear)
                    .HasColumnName("Nominee9_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9Gender)
                    .HasColumnName("Nominee9_Gender")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9HonorificMyanmar)
                    .HasColumnName("Nominee9_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.Nominee9Name)
                    .HasColumnName("Nominee9_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Nominee9Relationship)
                    .HasColumnName("Nominee9_Relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerDecision)
                    .HasColumnName("Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherDesignation)
                    .HasColumnName("Other_Designation")
                    .HasMaxLength(500);

                entity.Property(e => e.PermanentAddressNumber).HasColumnName("Permanent_Address_Number");

                entity.Property(e => e.PermanentRegion)
                    .HasColumnName("Permanent_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.PermanentStreet).HasColumnName("Permanent_Street");

                entity.Property(e => e.PermanentTownship)
                    .HasColumnName("Permanent_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.PermanentWard).HasColumnName("Permanent_Ward");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.Property(e => e.SpouseDobDay)
                    .HasColumnName("Spouse_DOB_Day")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseDobMonth)
                    .HasColumnName("Spouse_DOB_Month")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseDobYear)
                    .HasColumnName("Spouse_DOB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseHonorificMyanmar)
                    .HasColumnName("Spouse_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("Spouse_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbYear)
                    .HasColumnName("SSB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedTime).HasColumnName("Updated_Time");

                entity.Property(e => e.UpdatedUser).HasColumnName("Updated_User");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<EmployeePayment>(entity =>
            {
                entity.HasKey(e => e.Tranid);

                entity.ToTable("Employee_Payment");

                entity.Property(e => e.ConvertedSalary)
                    .HasColumnName("Converted_Salary")
                    .HasColumnType("money");

                entity.Property(e => e.Currency).HasMaxLength(10);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.EmployeeNameEnglish)
                    .HasColumnName("Employee_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNameMyanmar)
                    .HasColumnName("Employee_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeTotal)
                    .HasColumnName("Employee_Total")
                    .HasColumnType("money");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentTotal)
                    .HasColumnName("Establishment_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.GrandTotal)
                    .HasColumnName("Grand_Total")
                    .HasColumnType("money");

                entity.Property(e => e.IsAdditionalUnPaid)
                    .HasColumnName("IsAdditional_UnPaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Law1EmployeePayment)
                    .HasColumnName("Law1_Employee_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.Law1EstablishmentPayment)
                    .HasColumnName("Law1_Establishment_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.Law1Penalty)
                    .HasColumnName("Law1_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law1Total)
                    .HasColumnName("Law1_Total")
                    .HasColumnType("money");

                entity.Property(e => e.Law2EmployeePayment)
                    .HasColumnName("Law2_Employee_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.Law2EstablishmentPayment)
                    .HasColumnName("Law2_Establishment_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Penalty)
                    .HasColumnName("Law2_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Total)
                    .HasColumnName("Law2_Total")
                    .HasColumnType("money");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyTotal)
                    .HasColumnName("Penalty_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EmployeeUpload>(entity =>
            {
                entity.ToTable("Employee_Upload");

                entity.Property(e => e.EmployeeUploadId).HasColumnName("Employee_Upload_Id");

                entity.Property(e => e.EmployeeApplicationId).HasColumnName("Employee_Application_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.FpLeft)
                    .HasColumnName("FP_Left")
                    .HasMaxLength(1000);

                entity.Property(e => e.FpRight)
                    .HasColumnName("FP_Right")
                    .HasMaxLength(1000);

                entity.Property(e => e.Photo).HasMaxLength(1000);

                entity.Property(e => e.Ssn)
                    .IsRequired()
                    .HasColumnName("SSN")
                    .HasMaxLength(100);

                entity.Property(e => e.Upload1).HasMaxLength(1000);

                entity.Property(e => e.Upload10).HasMaxLength(1000);

                entity.Property(e => e.Upload2).HasMaxLength(1000);

                entity.Property(e => e.Upload3).HasMaxLength(1000);

                entity.Property(e => e.Upload4).HasMaxLength(1000);

                entity.Property(e => e.Upload5).HasMaxLength(1000);

                entity.Property(e => e.Upload6).HasMaxLength(1000);

                entity.Property(e => e.Upload7).HasMaxLength(1000);

                entity.Property(e => e.Upload8).HasMaxLength(1000);

                entity.Property(e => e.Upload9).HasMaxLength(1000);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<Establishment>(entity =>
            {
                entity.HasKey(e => new { e.EstablishmentId, e.EstablishmentNo })
                    .HasName("PK_Registered_Work");

                entity.Property(e => e.EstablishmentId)
                    .HasColumnName("Establishment_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BankId).HasColumnName("Bank_Id");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentEmail)
                    .HasColumnName("Establishment_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentFax)
                    .HasColumnName("Establishment_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentPhone)
                    .HasColumnName("Establishment_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentStartDate)
                    .HasColumnName("Establishment_Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentTypeCode)
                    .HasColumnName("Establishment_Type_Code")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentTypeL1)
                    .HasColumnName("Establishment_Type_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentTypeL2)
                    .HasColumnName("Establishment_Type_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.EstablishmentWebsite)
                    .HasColumnName("Establishment_Website")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeAddressNumber).HasColumnName("InCharge_Address_Number");

                entity.Property(e => e.InChargeAddressStreet).HasColumnName("InCharge_Address_Street");

                entity.Property(e => e.InChargeAddressWard).HasColumnName("InCharge_Address_Ward");

                entity.Property(e => e.InChargeGender).HasColumnName("InCharge_Gender");

                entity.Property(e => e.InChargeNameEnglish)
                    .HasColumnName("InCharge_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNameMyanmar)
                    .HasColumnName("InCharge_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNrcNo)
                    .HasColumnName("InCharge_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcSr)
                    .HasColumnName("InCharge_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcTownship)
                    .HasColumnName("InCharge_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcType)
                    .HasColumnName("InCharge_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargePassport)
                    .HasColumnName("InCharge_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargePhone)
                    .HasColumnName("InCharge_Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeRegion)
                    .HasColumnName("InCharge_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeTownship)
                    .HasColumnName("InCharge_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.InchargeHonorificEnglish)
                    .HasColumnName("Incharge_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeHonorificMyanmar)
                    .HasColumnName("Incharge_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeNationality)
                    .HasColumnName("Incharge_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.MyCoRegistrationDate)
                    .HasColumnName("MyCo_Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MyCoRegistrationNumber)
                    .HasColumnName("MyCo_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherEstablishmentType)
                    .HasColumnName("Other_Establishment_Type")
                    .HasMaxLength(500);

                entity.Property(e => e.OtherRegistrationNumber)
                    .HasColumnName("Other_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerAddressNumber).HasColumnName("Owner_Address_Number");

                entity.Property(e => e.OwnerAddressStreet).HasColumnName("Owner_Address_Street");

                entity.Property(e => e.OwnerAddressWard).HasColumnName("Owner_Address_Ward");

                entity.Property(e => e.OwnerGender).HasColumnName("Owner_Gender");

                entity.Property(e => e.OwnerHonorificEnglish)
                    .HasColumnName("Owner_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerHonorificMyanmar)
                    .HasColumnName("Owner_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNationality)
                    .HasColumnName("Owner_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNrcNo)
                    .HasColumnName("Owner_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcSr)
                    .HasColumnName("Owner_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcTownship)
                    .HasColumnName("Owner_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcType)
                    .HasColumnName("Owner_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerPassport)
                    .HasColumnName("Owner_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerPhone)
                    .HasColumnName("Owner_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerRegion)
                    .HasColumnName("Owner_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerTownship)
                    .HasColumnName("Owner_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnershipType)
                    .HasColumnName("Ownership_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.RegionInfo).HasMaxLength(500);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbYear)
                    .HasColumnName("SSB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetInfo).HasMaxLength(500);

                entity.Property(e => e.TinNumber)
                    .HasColumnName("TIN_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipInfo).HasMaxLength(500);

                entity.Property(e => e.UnitLevelInfo).HasMaxLength(500);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<EstablishmentApplication>(entity =>
            {
                entity.ToTable("Establishment_Application");

                entity.Property(e => e.EstablishmentApplicationId).HasColumnName("Establishment_Application_Id");

                entity.Property(e => e.AmendmentTypeDate)
                    .HasColumnName("AmendmentType_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeName)
                    .HasColumnName("AmendmentType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BankId).HasColumnName("Bank_Id");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentEmail)
                    .HasColumnName("Establishment_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentFax)
                    .HasColumnName("Establishment_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentPhone)
                    .HasColumnName("Establishment_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentStartDate)
                    .HasColumnName("Establishment_Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EstablishmentState).HasColumnName("Establishment_State");

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentTypeCode)
                    .HasColumnName("Establishment_Type_Code")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentTypeL1)
                    .HasColumnName("Establishment_Type_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentTypeL2)
                    .HasColumnName("Establishment_Type_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.EstablishmentWebsite)
                    .HasColumnName("Establishment_Website")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeAddressNumber).HasColumnName("InCharge_Address_Number");

                entity.Property(e => e.InChargeAddressStreet).HasColumnName("InCharge_Address_Street");

                entity.Property(e => e.InChargeAddressWard).HasColumnName("InCharge_Address_Ward");

                entity.Property(e => e.InChargeGender).HasColumnName("InCharge_Gender");

                entity.Property(e => e.InChargeNameEnglish)
                    .HasColumnName("InCharge_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNameMyanmar)
                    .HasColumnName("InCharge_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNrcNo)
                    .HasColumnName("InCharge_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcSr)
                    .HasColumnName("InCharge_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcTownship)
                    .HasColumnName("InCharge_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcType)
                    .HasColumnName("InCharge_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargePassport)
                    .HasColumnName("InCharge_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargePhone)
                    .HasColumnName("InCharge_Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeRegion)
                    .HasColumnName("InCharge_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeTownship)
                    .HasColumnName("InCharge_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.InchargeHonorificEnglish)
                    .HasColumnName("Incharge_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeHonorificMyanmar)
                    .HasColumnName("Incharge_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeNationality)
                    .HasColumnName("Incharge_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.MyCoRegistrationDate)
                    .HasColumnName("MyCo_Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MyCoRegistrationNumber)
                    .HasColumnName("MyCo_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerDecision)
                    .HasColumnName("Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerRemark)
                    .HasColumnName("Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.OfficerState).HasColumnName("Officer_State");

                entity.Property(e => e.OtherEstablishmentType)
                    .HasColumnName("Other_Establishment_Type")
                    .HasMaxLength(500);

                entity.Property(e => e.OtherRegistrationNumber)
                    .HasColumnName("Other_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerAddressNumber).HasColumnName("Owner_Address_Number");

                entity.Property(e => e.OwnerAddressStreet).HasColumnName("Owner_Address_Street");

                entity.Property(e => e.OwnerAddressWard).HasColumnName("Owner_Address_Ward");

                entity.Property(e => e.OwnerGender).HasColumnName("Owner_Gender");

                entity.Property(e => e.OwnerHonorificEnglish)
                    .HasColumnName("Owner_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerHonorificMyanmar)
                    .HasColumnName("Owner_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNationality)
                    .HasColumnName("Owner_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNrcNo)
                    .HasColumnName("Owner_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcSr)
                    .HasColumnName("Owner_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcTownship)
                    .HasColumnName("Owner_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcType)
                    .HasColumnName("Owner_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerPassport)
                    .HasColumnName("Owner_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerPhone)
                    .HasColumnName("Owner_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerRegion)
                    .HasColumnName("Owner_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerTownship)
                    .HasColumnName("Owner_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnershipType)
                    .HasColumnName("Ownership_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.RegionInfo).HasMaxLength(500);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetInfo).HasMaxLength(500);

                entity.Property(e => e.TinNumber)
                    .HasColumnName("TIN_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipInfo).HasMaxLength(500);

                entity.Property(e => e.UnitLevelInfo).HasMaxLength(500);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<EstablishmentHistory>(entity =>
            {
                entity.ToTable("Establishment_History");

                entity.Property(e => e.EstablishmentHistoryId).HasColumnName("Establishment_History_Id");

                entity.Property(e => e.AmendmentTypeDate)
                    .HasColumnName("AmendmentType_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeName)
                    .HasColumnName("AmendmentType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BankId).HasColumnName("Bank_Id");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentEmail)
                    .HasColumnName("Establishment_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentFax)
                    .HasColumnName("Establishment_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentPhone)
                    .HasColumnName("Establishment_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentStartDate)
                    .HasColumnName("Establishment_Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentTypeCode)
                    .HasColumnName("Establishment_Type_Code")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentTypeL1)
                    .HasColumnName("Establishment_Type_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentTypeL2)
                    .HasColumnName("Establishment_Type_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.EstablishmentWebsite)
                    .HasColumnName("Establishment_Website")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeAddressNumber).HasColumnName("InCharge_Address_Number");

                entity.Property(e => e.InChargeAddressStreet).HasColumnName("InCharge_Address_Street");

                entity.Property(e => e.InChargeAddressWard).HasColumnName("InCharge_Address_Ward");

                entity.Property(e => e.InChargeGender).HasColumnName("InCharge_Gender");

                entity.Property(e => e.InChargeNameEnglish)
                    .HasColumnName("InCharge_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNameMyanmar)
                    .HasColumnName("InCharge_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNrcNo)
                    .HasColumnName("InCharge_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcSr)
                    .HasColumnName("InCharge_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcTownship)
                    .HasColumnName("InCharge_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcType)
                    .HasColumnName("InCharge_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargePassport)
                    .HasColumnName("InCharge_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargePhone)
                    .HasColumnName("InCharge_Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeRegion)
                    .HasColumnName("InCharge_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeTownship)
                    .HasColumnName("InCharge_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.InchargeHonorificEnglish)
                    .HasColumnName("Incharge_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeHonorificMyanmar)
                    .HasColumnName("Incharge_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeNationality)
                    .HasColumnName("Incharge_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.MyCoRegistrationDate)
                    .HasColumnName("MyCo_Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MyCoRegistrationNumber)
                    .HasColumnName("MyCo_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerDecision)
                    .HasColumnName("Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerRemark)
                    .HasColumnName("Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.OtherEstablishmentType)
                    .HasColumnName("Other_Establishment_Type")
                    .HasMaxLength(500);

                entity.Property(e => e.OtherRegistrationNumber)
                    .HasColumnName("Other_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerAddressNumber).HasColumnName("Owner_Address_Number");

                entity.Property(e => e.OwnerAddressStreet).HasColumnName("Owner_Address_Street");

                entity.Property(e => e.OwnerAddressWard).HasColumnName("Owner_Address_Ward");

                entity.Property(e => e.OwnerGender).HasColumnName("Owner_Gender");

                entity.Property(e => e.OwnerHonorificEnglish)
                    .HasColumnName("Owner_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerHonorificMyanmar)
                    .HasColumnName("Owner_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNationality)
                    .HasColumnName("Owner_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNrcNo)
                    .HasColumnName("Owner_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcSr)
                    .HasColumnName("Owner_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcTownship)
                    .HasColumnName("Owner_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcType)
                    .HasColumnName("Owner_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerPassport)
                    .HasColumnName("Owner_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerPhone)
                    .HasColumnName("Owner_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerRegion)
                    .HasColumnName("Owner_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerTownship)
                    .HasColumnName("Owner_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnershipType)
                    .HasColumnName("Ownership_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.RegionInfo).HasMaxLength(500);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbYear)
                    .HasColumnName("SSB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetInfo).HasMaxLength(500);

                entity.Property(e => e.TinNumber)
                    .HasColumnName("TIN_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipInfo).HasMaxLength(500);

                entity.Property(e => e.UnitLevelInfo).HasMaxLength(500);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedTime).HasColumnName("Updated_Time");

                entity.Property(e => e.UpdatedUser).HasColumnName("Updated_User");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<EstablishmentHistoryNew>(entity =>
            {
                entity.ToTable("Establishment_History_New");

                entity.Property(e => e.EstablishmentHistoryNewId).HasColumnName("Establishment_History_New_Id");

                entity.Property(e => e.AmendmentTypeDate)
                    .HasColumnName("AmendmentType_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeName)
                    .HasColumnName("AmendmentType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BankId).HasColumnName("Bank_Id");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentEmail)
                    .HasColumnName("Establishment_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentFax)
                    .HasColumnName("Establishment_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentHistoryId).HasColumnName("Establishment_History_Id");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentPhone)
                    .HasColumnName("Establishment_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentStartDate)
                    .HasColumnName("Establishment_Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentTypeCode)
                    .HasColumnName("Establishment_Type_Code")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentTypeL1)
                    .HasColumnName("Establishment_Type_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentTypeL2)
                    .HasColumnName("Establishment_Type_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.EstablishmentWebsite)
                    .HasColumnName("Establishment_Website")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeAddressNumber).HasColumnName("InCharge_Address_Number");

                entity.Property(e => e.InChargeAddressStreet).HasColumnName("InCharge_Address_Street");

                entity.Property(e => e.InChargeAddressWard).HasColumnName("InCharge_Address_Ward");

                entity.Property(e => e.InChargeGender).HasColumnName("InCharge_Gender");

                entity.Property(e => e.InChargeNameEnglish)
                    .HasColumnName("InCharge_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNameMyanmar)
                    .HasColumnName("InCharge_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNrcNo)
                    .HasColumnName("InCharge_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcSr)
                    .HasColumnName("InCharge_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcTownship)
                    .HasColumnName("InCharge_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcType)
                    .HasColumnName("InCharge_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargePassport)
                    .HasColumnName("InCharge_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargePhone)
                    .HasColumnName("InCharge_Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeRegion)
                    .HasColumnName("InCharge_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeTownship)
                    .HasColumnName("InCharge_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.InchargeHonorificEnglish)
                    .HasColumnName("Incharge_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeHonorificMyanmar)
                    .HasColumnName("Incharge_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeNationality)
                    .HasColumnName("Incharge_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.MyCoRegistrationDate)
                    .HasColumnName("MyCo_Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MyCoRegistrationNumber)
                    .HasColumnName("MyCo_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerDecision)
                    .HasColumnName("Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerRemark)
                    .HasColumnName("Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.OtherEstablishmentType)
                    .HasColumnName("Other_Establishment_Type")
                    .HasMaxLength(500);

                entity.Property(e => e.OtherRegistrationNumber)
                    .HasColumnName("Other_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerAddressNumber).HasColumnName("Owner_Address_Number");

                entity.Property(e => e.OwnerAddressStreet).HasColumnName("Owner_Address_Street");

                entity.Property(e => e.OwnerAddressWard).HasColumnName("Owner_Address_Ward");

                entity.Property(e => e.OwnerGender).HasColumnName("Owner_Gender");

                entity.Property(e => e.OwnerHonorificEnglish)
                    .HasColumnName("Owner_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerHonorificMyanmar)
                    .HasColumnName("Owner_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNationality)
                    .HasColumnName("Owner_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNrcNo)
                    .HasColumnName("Owner_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcSr)
                    .HasColumnName("Owner_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcTownship)
                    .HasColumnName("Owner_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcType)
                    .HasColumnName("Owner_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerPassport)
                    .HasColumnName("Owner_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerPhone)
                    .HasColumnName("Owner_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerRegion)
                    .HasColumnName("Owner_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerTownship)
                    .HasColumnName("Owner_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnershipType)
                    .HasColumnName("Ownership_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.RegionInfo).HasMaxLength(500);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbYear)
                    .HasColumnName("SSB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetInfo).HasMaxLength(500);

                entity.Property(e => e.TinNumber)
                    .HasColumnName("TIN_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipInfo).HasMaxLength(500);

                entity.Property(e => e.UnitLevelInfo).HasMaxLength(500);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedTime).HasColumnName("Updated_Time");

                entity.Property(e => e.UpdatedUser).HasColumnName("Updated_User");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<EstablishmentPayment>(entity =>
            {
                entity.HasKey(e => e.Tranid);

                entity.ToTable("Establishment_Payment");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.GrandTotal)
                    .HasColumnName("Grand_Total")
                    .HasColumnType("money");

                entity.Property(e => e.IsAdditionalUnPaid)
                    .HasColumnName("IsAdditional_UnPaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Law1Penalty)
                    .HasColumnName("Law1_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law1Total)
                    .HasColumnName("Law1_Total")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Penalty)
                    .HasColumnName("Law2_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Total)
                    .HasColumnName("Law2_Total")
                    .HasColumnType("money");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyTotal)
                    .HasColumnName("Penalty_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TotalLateDay).HasColumnName("Total_Late_Day");
            });

            modelBuilder.Entity<EstablishmentType>(entity =>
            {
                entity.ToTable("Establishment_Type");

                entity.Property(e => e.EstablishmentTypeId).HasColumnName("Establishment_Type_Id");

                entity.Property(e => e.EstablishmentTypeCode)
                    .HasColumnName("Establishment_Type_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentTypeName)
                    .HasColumnName("Establishment_Type_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.ParentCode)
                    .HasColumnName("Parent_Code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EstablishmentUpload>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Establishment_Upload");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.Upload1).HasMaxLength(1000);

                entity.Property(e => e.Upload10).HasMaxLength(1000);

                entity.Property(e => e.Upload2).HasMaxLength(1000);

                entity.Property(e => e.Upload3).HasMaxLength(1000);

                entity.Property(e => e.Upload4).HasMaxLength(1000);

                entity.Property(e => e.Upload5).HasMaxLength(1000);

                entity.Property(e => e.Upload6).HasMaxLength(1000);

                entity.Property(e => e.Upload7).HasMaxLength(1000);

                entity.Property(e => e.Upload8).HasMaxLength(1000);

                entity.Property(e => e.Upload9).HasMaxLength(1000);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<ExchangeRate>(entity =>
            {
                entity.ToTable("Exchange_Rate");

                entity.Property(e => e.ExchangeRate1)
                    .HasColumnName("Exchange_Rate")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.GenderId)
                    .HasColumnName("Gender_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GenderName)
                    .HasColumnName("Gender_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GeneralPayment>(entity =>
            {
                entity.ToTable("General_Payment");

                entity.Property(e => e.GeneralPaymentId).HasColumnName("General_Payment_Id");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BankChannel)
                    .HasColumnName("Bank_Channel")
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EstablishmentId)
                    .HasColumnName("Establishment_Id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GeneralPaymentTypeId).HasColumnName("General_Payment_Type_Id");

                entity.Property(e => e.IsSuccess).HasMaxLength(50);

                entity.Property(e => e.LawId).HasColumnName("Law_Id");

                entity.Property(e => e.PaymentReferenceNo)
                    .HasColumnName("Payment_Reference_No")
                    .HasMaxLength(500);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<GeneralPaymentType>(entity =>
            {
                entity.ToTable("General_Payment_Type");

                entity.Property(e => e.GeneralPaymentTypeId).HasColumnName("General_Payment_Type_Id");

                entity.Property(e => e.GeneralPaymentTypeName)
                    .HasColumnName("General_Payment_Type_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LawId).HasColumnName("Law_Id");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobHistory>(entity =>
            {
                entity.ToTable("Job_History");

                entity.Property(e => e.JobHistoryId).HasColumnName("Job_History_Id");

                entity.Property(e => e.EmployeeNameEnglish)
                    .HasColumnName("Employee_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNameMyanmar)
                    .HasColumnName("Employee_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.JoinDate)
                    .HasColumnName("Join_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveDate)
                    .HasColumnName("Leave_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Law>(entity =>
            {
                entity.Property(e => e.LawId).HasColumnName("Law_Id");

                entity.Property(e => e.EmployeePercent).HasColumnName("Employee_Percent");

                entity.Property(e => e.EstablishmentPercent).HasColumnName("Establishment_Percent");

                entity.Property(e => e.LawName)
                    .HasColumnName("Law_Name")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.Property(e => e.MaritalStatusId)
                    .HasColumnName("MaritalStatus_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MaritalStatusType)
                    .HasColumnName("MaritalStatus_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MpuLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("MPU_Log");

                entity.Property(e => e.LogId).HasColumnName("Log_Id");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.LogStatus)
                    .HasColumnName("Log_Status")
                    .HasMaxLength(100);

                entity.Property(e => e.MpuReference)
                    .HasColumnName("MPU_Reference")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MpuResponse>(entity =>
            {
                entity.ToTable("MPU_Response");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovalCode)
                    .HasColumnName("approvalCode")
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("categoryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTime)
                    .HasColumnName("dateTime")
                    .HasMaxLength(50);

                entity.Property(e => e.FailReason)
                    .HasColumnName("failReason")
                    .HasMaxLength(50);

                entity.Property(e => e.HashValue)
                    .HasColumnName("hashValue")
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("invoiceNo")
                    .HasMaxLength(50);

                entity.Property(e => e.MerchantId)
                    .HasColumnName("merchantID")
                    .HasMaxLength(50);

                entity.Property(e => e.Pan)
                    .HasColumnName("pan")
                    .HasMaxLength(50);

                entity.Property(e => e.RespCode)
                    .HasColumnName("respCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.TranRef)
                    .HasColumnName("tranRef")
                    .HasMaxLength(50);

                entity.Property(e => e.UserDefined1)
                    .HasColumnName("userDefined1")
                    .HasMaxLength(50);

                entity.Property(e => e.UserDefined2)
                    .HasColumnName("userDefined2")
                    .HasMaxLength(50);

                entity.Property(e => e.UserDefined3)
                    .HasColumnName("userDefined3")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NationalityId)
                    .HasColumnName("Nationality_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasColumnName("Nationality_Name")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<NotificationHistory>(entity =>
            {
                entity.ToTable("Notification_History");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FromId).HasColumnName("From_Id");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("Notification_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.NotificationType).HasColumnName("Notification_Type");

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.ToId).HasColumnName("To_Id");
            });

            modelBuilder.Entity<NrcSr>(entity =>
            {
                entity.HasKey(e => e.NrcSrCode);

                entity.ToTable("NRC_SR");

                entity.Property(e => e.NrcSrCode)
                    .HasColumnName("NRC_SR_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NrcSrName)
                    .IsRequired()
                    .HasColumnName("NRC_SR_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.NrcSrOldDbformat)
                    .HasColumnName("NRC_SR_OldDBFormat")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<NrcTownship>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NRC_Township");

                entity.Property(e => e.NrcSrCode)
                    .HasColumnName("NRC_SR_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NrcTownshipCode)
                    .IsRequired()
                    .HasColumnName("NRC_Township_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NrcTownshipName)
                    .HasColumnName("NRC_Township_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NrcType>(entity =>
            {
                entity.HasKey(e => e.NrcTypeCode);

                entity.ToTable("NRC_Type");

                entity.Property(e => e.NrcTypeCode)
                    .HasColumnName("NRC_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NrcTypeName)
                    .HasColumnName("NRC_Type_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.NrcTypeOldDbformat)
                    .HasColumnName("NRC_Type_OldDBFormat")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.Property(e => e.OfficeId).HasColumnName("Office_Id");

                entity.Property(e => e.LastCaseNo).HasColumnName("Last_CaseNo");

                entity.Property(e => e.LastEmpSsn).HasColumnName("Last_EmpSSN");

                entity.Property(e => e.LastEstSsn).HasColumnName("Last_EstSSN");

                entity.Property(e => e.LastInvoiceNo).HasColumnName("Last_InvoiceNo");

                entity.Property(e => e.LastReceiptNo).HasColumnName("Last_ReceiptNo");

                entity.Property(e => e.OfficeEmail)
                    .HasColumnName("Office_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficeName)
                    .HasColumnName("Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SrPcode)
                    .HasColumnName("SR_Pcode")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbBankAccount)
                    .HasColumnName("SSB_Bank_Account")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbBankName)
                    .HasColumnName("SSB_Bank_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.TownshipPcode)
                    .HasColumnName("Township_Pcode")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Officer>(entity =>
            {
                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.LoginType).HasMaxLength(50);

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<OfficerHistory>(entity =>
            {
                entity.ToTable("Officer_History");

                entity.Property(e => e.OfficerHistoryId).HasColumnName("Officer_History_Id");

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedTime).HasColumnName("Updated_Time");

                entity.Property(e => e.UpdatedUser).HasColumnName("Updated_User");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<OfficerPosition>(entity =>
            {
                entity.ToTable("Officer_Position");

                entity.Property(e => e.OfficerPositionId).HasColumnName("Officer_Position_Id");

                entity.Property(e => e.OfficerPosition1)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Opening>(entity =>
            {
                entity.Property(e => e.OpeningId).HasColumnName("Opening_Id");

                entity.Property(e => e.AllowanceDate)
                    .HasColumnName("Allowance_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BuildingArea)
                    .HasColumnName("Building_Area")
                    .HasMaxLength(1000);

                entity.Property(e => e.CommencingDate)
                    .HasColumnName("Commencing_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentType)
                    .HasColumnName("Establishment_Type")
                    .HasMaxLength(1000);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.LandArea)
                    .HasColumnName("Land_Area")
                    .HasMaxLength(1000);

                entity.Property(e => e.LicenseNo)
                    .HasColumnName("License_No")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OpeningApplication>(entity =>
            {
                entity.ToTable("Opening_Application");

                entity.Property(e => e.OpeningApplicationId).HasColumnName("Opening_Application_Id");

                entity.Property(e => e.AllowanceDate)
                    .HasColumnName("Allowance_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BuildingArea)
                    .HasColumnName("Building_Area")
                    .HasMaxLength(1000);

                entity.Property(e => e.CommencingDate)
                    .HasColumnName("Commencing_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentState).HasColumnName("Establishment_State");

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentType)
                    .HasColumnName("Establishment_Type")
                    .HasMaxLength(1000);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.LandArea)
                    .HasColumnName("Land_Area")
                    .HasMaxLength(1000);

                entity.Property(e => e.LicenseNo)
                    .HasColumnName("License_No")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerState).HasColumnName("Officer_State");

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<OpeningHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Opening_History");

                entity.Property(e => e.AllowanceDate)
                    .HasColumnName("Allowance_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BuildingArea)
                    .HasColumnName("Building_Area")
                    .HasMaxLength(1000);

                entity.Property(e => e.CommencingDate)
                    .HasColumnName("Commencing_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentType)
                    .HasColumnName("Establishment_Type")
                    .HasMaxLength(1000);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.LandArea)
                    .HasColumnName("Land_Area")
                    .HasMaxLength(1000);

                entity.Property(e => e.LicenseNo)
                    .HasColumnName("License_No")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerNumber)
                    .HasColumnName("Officer_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(50);

                entity.Property(e => e.OpeningHistoryId).HasColumnName("Opening_History_Id");

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbYear)
                    .HasColumnName("SSB_Year")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedTime).HasColumnName("Updated_Time");

                entity.Property(e => e.UpdatedUser).HasColumnName("Updated_User");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.Property(e => e.OperatorId).HasColumnName("Operator_Id");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.LastUpdateDate).HasColumnType("date");

                entity.Property(e => e.OperatorAssociation)
                    .HasColumnName("Operator_Association")
                    .HasMaxLength(1000);

                entity.Property(e => e.OperatorBranch)
                    .HasColumnName("Operator_Branch")
                    .HasMaxLength(1000);

                entity.Property(e => e.OperatorDepartment)
                    .HasColumnName("Operator_Department")
                    .HasMaxLength(1000);

                entity.Property(e => e.OperatorName)
                    .HasColumnName("Operator_Name")
                    .HasMaxLength(1000);

                entity.Property(e => e.OperatorPosition)
                    .HasColumnName("Operator_Position")
                    .HasMaxLength(1000);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<OwnershipType>(entity =>
            {
                entity.HasKey(e => e.OwnershipType1);

                entity.ToTable("Ownership_Type");

                entity.Property(e => e.OwnershipType1).HasColumnName("Ownership_Type");

                entity.Property(e => e.OwnershipTypeName)
                    .HasColumnName("Ownership_Type_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.Property(e => e.RelationshipId).HasColumnName("Relationship_Id");

                entity.Property(e => e.RelationshipName)
                    .HasColumnName("Relationship_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SalaryHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Salary_History");

                entity.Property(e => e.ConvertedSalary)
                    .HasColumnName("Converted_Salary")
                    .HasColumnType("money");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score })
                    .HasName("IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sr>(entity =>
            {
                entity.HasKey(e => e.SrPcode);

                entity.ToTable("SR");

                entity.Property(e => e.SrPcode)
                    .HasColumnName("SR_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.SrName)
                    .HasColumnName("SR_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SsbReceiptLog>(entity =>
            {
                entity.HasKey(e => e.SsbReceiptNo);

                entity.ToTable("SSB_Receipt_Log");

                entity.Property(e => e.SsbReceiptNo)
                    .HasColumnName("SSB_ReceiptNo")
                    .HasMaxLength(100);

                entity.Property(e => e.BankReferenceNo)
                    .HasColumnName("Bank_ReferenceNo")
                    .HasMaxLength(1000);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BackupPath).HasMaxLength(500);

                entity.Property(e => e.MaxSalary).HasColumnType("money");

                entity.Property(e => e.ServiceCharges).HasColumnType("money");

                entity.Property(e => e.SystemSettingId).HasColumnName("SystemSetting_Id");
            });

            modelBuilder.Entity<TempEstablishmentApplication>(entity =>
            {
                entity.ToTable("Temp_Establishment_Application");

                entity.Property(e => e.TempEstablishmentApplicationId).HasColumnName("Temp_Establishment_Application_Id");

                entity.Property(e => e.AmendmentTypeDate)
                    .HasColumnName("AmendmentType_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AmendmentTypeId).HasColumnName("AmendmentType_Id");

                entity.Property(e => e.AmendmentTypeName)
                    .HasColumnName("AmendmentType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AmendmentTypeRemark)
                    .HasColumnName("AmendmentType_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.AmendmentTypeRemark2)
                    .HasColumnName("AmendmentType_Remark2")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("Application_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BankId).HasColumnName("Bank_Id");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentAddressNumber).HasColumnName("Establishment_Address_Number");

                entity.Property(e => e.EstablishmentEmail)
                    .HasColumnName("Establishment_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentFax)
                    .HasColumnName("Establishment_Fax")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentPhone)
                    .HasColumnName("Establishment_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentRegion)
                    .HasColumnName("Establishment_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentStartDate)
                    .HasColumnName("Establishment_Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EstablishmentState).HasColumnName("Establishment_State");

                entity.Property(e => e.EstablishmentStreet).HasColumnName("Establishment_Street");

                entity.Property(e => e.EstablishmentTownship)
                    .HasColumnName("Establishment_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentTypeCode)
                    .HasColumnName("Establishment_Type_Code")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentTypeL1)
                    .HasColumnName("Establishment_Type_L1")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentTypeL2)
                    .HasColumnName("Establishment_Type_L2")
                    .HasMaxLength(50);

                entity.Property(e => e.EstablishmentWard).HasColumnName("Establishment_Ward");

                entity.Property(e => e.EstablishmentWebsite)
                    .HasColumnName("Establishment_Website")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeAddressNumber).HasColumnName("InCharge_Address_Number");

                entity.Property(e => e.InChargeAddressStreet).HasColumnName("InCharge_Address_Street");

                entity.Property(e => e.InChargeAddressWard).HasColumnName("InCharge_Address_Ward");

                entity.Property(e => e.InChargeGender).HasColumnName("InCharge_Gender");

                entity.Property(e => e.InChargeNameEnglish)
                    .HasColumnName("InCharge_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNameMyanmar)
                    .HasColumnName("InCharge_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargeNrcNo)
                    .HasColumnName("InCharge_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcSr)
                    .HasColumnName("InCharge_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcTownship)
                    .HasColumnName("InCharge_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeNrcType)
                    .HasColumnName("InCharge_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargePassport)
                    .HasColumnName("InCharge_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.InChargePhone)
                    .HasColumnName("InCharge_Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeRegion)
                    .HasColumnName("InCharge_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargeTownship)
                    .HasColumnName("InCharge_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.InchargeHonorificEnglish)
                    .HasColumnName("Incharge_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeHonorificMyanmar)
                    .HasColumnName("Incharge_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.InchargeNationality)
                    .HasColumnName("Incharge_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.MyCoRegistrationDate)
                    .HasColumnName("MyCo_Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MyCoRegistrationNumber)
                    .HasColumnName("MyCo_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerDecision)
                    .HasColumnName("Officer_Decision")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerRemark)
                    .HasColumnName("Officer_Remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.OfficerState).HasColumnName("Officer_State");

                entity.Property(e => e.OtherEstablishmentType)
                    .HasColumnName("Other_Establishment_Type")
                    .HasMaxLength(500);

                entity.Property(e => e.OtherRegistrationNumber)
                    .HasColumnName("Other_Registration_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerAddressNumber).HasColumnName("Owner_Address_Number");

                entity.Property(e => e.OwnerAddressStreet).HasColumnName("Owner_Address_Street");

                entity.Property(e => e.OwnerAddressWard).HasColumnName("Owner_Address_Ward");

                entity.Property(e => e.OwnerGender).HasColumnName("Owner_Gender");

                entity.Property(e => e.OwnerHonorificEnglish)
                    .HasColumnName("Owner_Honorific_English")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerHonorificMyanmar)
                    .HasColumnName("Owner_Honorific_Myanmar")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNameEnglish)
                    .HasColumnName("Owner_Name_English")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNameMyanmar)
                    .HasColumnName("Owner_Name_Myanmar")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerNationality)
                    .HasColumnName("Owner_Nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerNrcNo)
                    .HasColumnName("Owner_NRC_No")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcSr)
                    .HasColumnName("Owner_NRC_SR")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcTownship)
                    .HasColumnName("Owner_NRC_Township")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerNrcType)
                    .HasColumnName("Owner_NRC_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerPassport)
                    .HasColumnName("Owner_Passport")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerPhone)
                    .HasColumnName("Owner_Phone")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerRegion)
                    .HasColumnName("Owner_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerTownship)
                    .HasColumnName("Owner_Township")
                    .HasMaxLength(100);

                entity.Property(e => e.OwnershipType)
                    .HasColumnName("Ownership_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.RegionInfo).HasMaxLength(500);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbRegionCode)
                    .HasColumnName("SSB_Region_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbTownshipCode)
                    .HasColumnName("SSB_Township_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetInfo).HasMaxLength(500);

                entity.Property(e => e.TinNumber)
                    .HasColumnName("TIN_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipInfo).HasMaxLength(500);

                entity.Property(e => e.UnitLevelInfo).HasMaxLength(500);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<TmpCsvData>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.ToTable("Tmp_csvData");

                entity.Property(e => e.TranId).HasColumnName("Tran_Id");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.EstablishmentNo)
                    .IsRequired()
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReferenceCode)
                    .IsRequired()
                    .HasColumnName("Reference_Code")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<TmpEmployeePayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_Employee_Payment");

                entity.Property(e => e.ConvertedSalary)
                    .HasColumnName("Converted_Salary")
                    .HasColumnType("money");

                entity.Property(e => e.Currency).HasMaxLength(10);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.EmployeeNameEnglish)
                    .HasColumnName("Employee_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNameMyanmar)
                    .HasColumnName("Employee_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeTotal)
                    .HasColumnName("Employee_Total")
                    .HasColumnType("money");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.EstablishmentTotal)
                    .HasColumnName("Establishment_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.GrandTotal)
                    .HasColumnName("Grand_Total")
                    .HasColumnType("money");

                entity.Property(e => e.IsAdditionalUnPaid)
                    .HasColumnName("IsAdditional_UnPaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Law1EmployeePayment)
                    .HasColumnName("Law1_Employee_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.Law1EstablishmentPayment)
                    .HasColumnName("Law1_Establishment_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.Law1Penalty)
                    .HasColumnName("Law1_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law1Total)
                    .HasColumnName("Law1_Total")
                    .HasColumnType("money");

                entity.Property(e => e.Law2EmployeePayment)
                    .HasColumnName("Law2_Employee_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.Law2EstablishmentPayment)
                    .HasColumnName("Law2_Establishment_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Penalty)
                    .HasColumnName("Law2_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Total)
                    .HasColumnName("Law2_Total")
                    .HasColumnType("money");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyTotal)
                    .HasColumnName("Penalty_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<TmpEstablishmentPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_Establishment_Payment");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.GrandTotal)
                    .HasColumnName("Grand_Total")
                    .HasColumnType("money");

                entity.Property(e => e.IsAdditionalUnPaid)
                    .HasColumnName("IsAdditional_UnPaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Law1Penalty)
                    .HasColumnName("Law1_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law1Total)
                    .HasColumnName("Law1_Total")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Penalty)
                    .HasColumnName("Law2_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Total)
                    .HasColumnName("Law2_Total")
                    .HasColumnType("money");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyTotal)
                    .HasColumnName("Penalty_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TotalLateDay).HasColumnName("Total_Late_Day");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<TmpJsonData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_JsonData");

                entity.Property(e => e.ConvertedSalary)
                    .HasColumnName("Converted_Salary")
                    .HasColumnType("money");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<TmpPenaltyAllEstablishment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_Penalty_AllEstablishment");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.GrandTotal)
                    .HasColumnName("Grand_Total")
                    .HasColumnType("money");

                entity.Property(e => e.IsAdditionalUnPaid).HasColumnName("IsAdditional_UnPaid");

                entity.Property(e => e.Law1Penalty)
                    .HasColumnName("Law1_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law1Total)
                    .HasColumnName("Law1_Total")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Penalty)
                    .HasColumnName("Law2_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Total)
                    .HasColumnName("Law2_Total")
                    .HasColumnType("money");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyTotal)
                    .HasColumnName("Penalty_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TotalLateDay).HasColumnName("Total_Late_Day");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("User_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<TmpPenaltyByEstablishment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_Penalty_ByEstablishment");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeCount).HasColumnName("Employee_Count");

                entity.Property(e => e.EstablishmentId).HasColumnName("Establishment_Id");

                entity.Property(e => e.EstablishmentNameEnglish)
                    .HasColumnName("Establishment_Name_English")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNameMyanmar)
                    .HasColumnName("Establishment_Name_Myanmar")
                    .HasMaxLength(500);

                entity.Property(e => e.EstablishmentNo)
                    .HasColumnName("Establishment_No")
                    .HasMaxLength(100);

                entity.Property(e => e.GrandTotal)
                    .HasColumnName("Grand_Total")
                    .HasColumnType("money");

                entity.Property(e => e.IsAdditionalUnPaid).HasColumnName("IsAdditional_UnPaid");

                entity.Property(e => e.Law1Penalty)
                    .HasColumnName("Law1_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law1Total)
                    .HasColumnName("Law1_Total")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Penalty)
                    .HasColumnName("Law2_Penalty")
                    .HasColumnType("money");

                entity.Property(e => e.Law2Total)
                    .HasColumnName("Law2_Total")
                    .HasColumnType("money");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyTotal)
                    .HasColumnName("Penalty_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.SsbOfficeName)
                    .HasColumnName("SSB_Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TotalLateDay).HasColumnName("Total_Late_Day");
            });

            modelBuilder.Entity<Township>(entity =>
            {
                entity.HasKey(e => e.TownshipPcode);

                entity.Property(e => e.TownshipPcode)
                    .HasColumnName("Township_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictPcode)
                    .HasColumnName("District_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeName)
                    .HasColumnName("Office_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SrPcode)
                    .HasColumnName("SR_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.SsbOfficeCode)
                    .HasColumnName("SSB_Office_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.TownshipName)
                    .HasColumnName("Township_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tranid>(entity =>
            {
                entity.HasKey(e => e.Tranid1);

                entity.Property(e => e.Tranid1)
                    .HasColumnName("Tranid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TranidLog>(entity =>
            {
                entity.HasKey(e => e.Tranid);

                entity.ToTable("Tranid_Log");

                entity.Property(e => e.Tranid).ValueGeneratedNever();

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.SsbInvoiceNo)
                    .HasColumnName("SSB_InvoiceNo")
                    .HasMaxLength(1000);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.ActivationLink)
                    .HasColumnName("Activation_Link")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LoginType).HasMaxLength(50);

                entity.Property(e => e.OfficeId).HasColumnName("Office_Id");

                entity.Property(e => e.OfficerId).HasColumnName("Officer_Id");

                entity.Property(e => e.OfficerName)
                    .HasColumnName("Officer_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OfficerPosition)
                    .HasColumnName("Officer_Position")
                    .HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.PasswordResetLink)
                    .HasColumnName("PasswordReset_Link")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.UserLevelId).HasColumnName("UserLevel_Id");

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UsersLevel>(entity =>
            {
                entity.HasKey(e => e.UserLevelId)
                    .HasName("PK_UserLevel");

                entity.ToTable("Users_Level");

                entity.Property(e => e.UserLevelId).HasColumnName("UserLevel_Id");

                entity.Property(e => e.IsHeadOffice).HasColumnName("Is_HeadOffice");

                entity.Property(e => e.IsTownship).HasColumnName("Is_Township");

                entity.Property(e => e.UserLevelName)
                    .HasColumnName("UserLevel_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UsersPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("PK_Peremission");

                entity.ToTable("Users_Permission");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.ControlId).HasColumnName("Control_Id");

                entity.Property(e => e.CreateAccess).HasColumnName("Create_Access");

                entity.Property(e => e.DeleteAccess).HasColumnName("Delete_Access");

                entity.Property(e => e.EditAccess).HasColumnName("Edit_Access");

                entity.Property(e => e.FullAccess).HasColumnName("Full_Access");

                entity.Property(e => e.ListAccess).HasColumnName("List_Access");

                entity.Property(e => e.Udf1).HasColumnName("UDF1");

                entity.Property(e => e.Udf10).HasColumnName("UDF10");

                entity.Property(e => e.Udf11).HasColumnName("UDF11");

                entity.Property(e => e.Udf12).HasColumnName("UDF12");

                entity.Property(e => e.Udf13).HasColumnName("UDF13");

                entity.Property(e => e.Udf14).HasColumnName("UDF14");

                entity.Property(e => e.Udf15).HasColumnName("UDF15");

                entity.Property(e => e.Udf16).HasColumnName("UDF16");

                entity.Property(e => e.Udf17).HasColumnName("UDF17");

                entity.Property(e => e.Udf18).HasColumnName("UDF18");

                entity.Property(e => e.Udf19).HasColumnName("UDF19");

                entity.Property(e => e.Udf2).HasColumnName("UDF2");

                entity.Property(e => e.Udf20).HasColumnName("UDF20");

                entity.Property(e => e.Udf3).HasColumnName("UDF3");

                entity.Property(e => e.Udf4).HasColumnName("UDF4");

                entity.Property(e => e.Udf5).HasColumnName("UDF5");

                entity.Property(e => e.Udf6).HasColumnName("UDF6");

                entity.Property(e => e.Udf7).HasColumnName("UDF7");

                entity.Property(e => e.Udf8).HasColumnName("UDF8");

                entity.Property(e => e.Udf9).HasColumnName("UDF9");

                entity.Property(e => e.UserLevelId).HasColumnName("UserLevel_Id");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.HasKey(e => e.WardPcode);

                entity.Property(e => e.WardPcode)
                    .HasColumnName("Ward_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictPcode)
                    .HasColumnName("District_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.SrPcode)
                    .HasColumnName("SR_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipPcode)
                    .HasColumnName("Township_Pcode")
                    .HasMaxLength(50);

                entity.Property(e => e.WardName)
                    .HasColumnName("Ward_Name")
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
