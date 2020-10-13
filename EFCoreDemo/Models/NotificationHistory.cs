using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class NotificationHistory
    {
        public int Id { get; set; }
        public string NotificationId { get; set; }
        public string NotificationType { get; set; }
        public string Description { get; set; }
        public int? FromId { get; set; }
        public int? ToId { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public bool? IsRead { get; set; }
    }
}
