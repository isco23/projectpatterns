using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class UsersLevel
    {
        public int UserLevelId { get; set; }
        public string UserLevelName { get; set; }
        public bool? IsHeadOffice { get; set; }
        public bool? IsTownship { get; set; }
        public bool? IsActive { get; set; }
    }
}
