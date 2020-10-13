using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class SystemSetting
    {
        public int? SystemSettingId { get; set; }
        public string BackupPath { get; set; }
        public int? AutoCalculateDate { get; set; }
        public int? DividedBy { get; set; }
        public int? MultiplyBy { get; set; }
        public decimal? MaxSalary { get; set; }
        public decimal? ServiceCharges { get; set; }
    }
}
