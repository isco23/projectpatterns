using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Law
    {
        public int LawId { get; set; }
        public string LawName { get; set; }
        public byte? EstablishmentPercent { get; set; }
        public byte? EmployeePercent { get; set; }
    }
}
