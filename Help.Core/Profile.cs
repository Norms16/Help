
using System;

namespace Help.Domain
{
    /// <summary>
    /// Reprsents organzation Profile 
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

