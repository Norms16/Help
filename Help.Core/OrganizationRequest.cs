
using System;

namespace Help.Domain
{
    /// <summary>
    /// This holds request from Organization 
    /// to be approved by the appropraite body
    /// </summary>
    public partial class OrganizationRequest
    {
        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public int? RequestTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
    }

}
