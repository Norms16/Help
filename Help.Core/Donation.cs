using System;


namespace Help.Domain
{
    /// <summary>
    /// Donation or Transaction made
    /// </summary>
    public partial class Donation
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public int? SupportTypeId { get; set; }
        public int? BeneficiaryId { get; set; }

        public string BeneficiaryType { get; set; }
        public DateTime? Amount { get; set; }
        public string Tref { get; set; }
        public string TRefCode { get; set; }
        public DateTime? TDate { get; set; }
        public string Status { get; set; }
        public DateTime? Date { get; set; }
       
    }
}


