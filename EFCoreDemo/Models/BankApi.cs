using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class BankApi
    {
        public int BankApiId { get; set; }
        public string BankName { get; set; }
        public string BankApiKey { get; set; }
        public string Password { get; set; }
    }
}
