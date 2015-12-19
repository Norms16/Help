
using System;

namespace Help.Domain
{
    public partial class OrganizationRequest
    {
        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public int? RequestTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
    }

}
