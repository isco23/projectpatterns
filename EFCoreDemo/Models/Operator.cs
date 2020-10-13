using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Operator
    {
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string OperatorPosition { get; set; }
        public string OperatorDepartment { get; set; }
        public string OperatorBranch { get; set; }
        public string OperatorAssociation { get; set; }
        public int? UserId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public TimeSpan? CreatedTime { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public TimeSpan? LastUpdateTime { get; set; }
    }
}
