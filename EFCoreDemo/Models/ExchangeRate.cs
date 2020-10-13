using System;
using System.Collections.Generic;

namespace EFCoreDemo_DbFirst.Models
{
    public partial class ExchangeRate
    {
        public int Id { get; set; }
        public byte? Month { get; set; }
        public int? Year { get; set; }
        public decimal? ExchangeRate1 { get; set; }
    }
}
