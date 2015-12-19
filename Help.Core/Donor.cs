

namespace Help.Domain
{
    public partial class Donor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; } 
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
