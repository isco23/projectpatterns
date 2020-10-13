using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class EmailNoti
    {
        public int EmailNotiId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string NotiType { get; set; }
        public string OfficerDescription { get; set; }
    }
}
