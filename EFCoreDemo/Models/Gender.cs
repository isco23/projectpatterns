using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class Gender
    {
        public byte GenderId { get; set; }
        public string GenderName { get; set; }
    }
}
