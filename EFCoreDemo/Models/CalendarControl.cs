using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class CalendarControl
    {
        public int CalendarId { get; set; }
        public int? EstablishmentId { get; set; }
        public string EstablishmentNo { get; set; }
        public string EstablishmentName { get; set; }
        public int? Year { get; set; }
        public string Month { get; set; }
        public int? UserId { get; set; }
        public bool? IsEnable { get; set; }
    }
}
