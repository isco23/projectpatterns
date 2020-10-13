using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class JobHistory
    {
        public int JobHistoryId { get; set; }
        public string Ssn { get; set; }
        public string EmployeeNameMyanmar { get; set; }
        public string EmployeeNameEnglish { get; set; }
        public string EstablishmentNo { get; set; }
        public string EstablishmentNameMyanmar { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public int? UserId { get; set; }
    }
}
