

namespace Help.Domain
{
    /// <summary>
    /// NGO
    /// </summary>
   public partial class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Motto { get; set; }
        public int? Reg_Type { get; set; } 
        public int? BankDetailId { get; set; }
        public int? CollationerId { get; set; }
        public int?  ContactId { get; set; }
        public int ProfileId { get; set; }
        public int OrganizationRequestId { get; set; }
    }
}

