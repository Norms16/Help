using System;


namespace Help.Domain
{
    /// <summary>
    /// Donation beneficiary: this can be an Individual or NGO Body 
    /// </summary>
    public partial class Beneficiary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NeedSummary { get; set; }
        public string Detail { get; set; }
        public int? BankDetailId { get; set; }
        public int ImageId { get; set; }
        public DateTime? Date { get; set; }
    }
}
