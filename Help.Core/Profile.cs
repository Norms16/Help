
using System;

namespace Help.Domain
{
    /// <summary>
    /// This class represents an Individual acoount 
    /// </summary>
    public partial class Profile
    {
        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public int? ImageId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime? Date { get; set; }
       
    }
}

