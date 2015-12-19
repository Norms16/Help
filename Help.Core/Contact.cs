
namespace Help.Domain
{
    /// <summary>
    /// This represents the Collationer or Organization contact person
    /// </summary>
    public partial class Contact
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        
    }

}
