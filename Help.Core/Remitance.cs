
using System;

namespace Help.Domain
{
    public partial class Remitance
    {
        public int Id { get; set; }
        public int? BeneficiaryId { get; set; }
        public string BeneficiaryType { get; set; }
        public DateTime? Datefrom { get; set; }
        public DateTime? Dateto { get; set; }
        public decimal? Total { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? RemitedAmount { get; set; }
        public DateTime? DateOfRemital { get; set; }
    }
}
