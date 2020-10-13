using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class TmpJsonData
    {
        public int? EstablishmentId { get; set; }
        public string EstablishmentNo { get; set; }
        public string Ssn { get; set; }
        public byte? Month { get; set; }
        public int? Year { get; set; }
        public decimal? ConvertedSalary { get; set; }
        public int? UserId { get; set; }
    }
}
