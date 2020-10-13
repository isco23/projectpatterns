using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class EstablishmentType
    {
        public int EstablishmentTypeId { get; set; }
        public string EstablishmentTypeCode { get; set; }
        public string EstablishmentTypeName { get; set; }
        public string ParentCode { get; set; }
    }
}
