using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte? UserLevelId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ActivationLink { get; set; }
        public string PasswordResetLink { get; set; }
        public int? OfficerId { get; set; }
        public string OfficerName { get; set; }
        public string OfficerPosition { get; set; }
        public int? OfficeId { get; set; }
        public string LoginType { get; set; }
        public int? LoginId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
