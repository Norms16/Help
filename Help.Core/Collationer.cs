using System;


namespace Help.Domain
{
    /// <summary>
    /// Collation body 
    /// </summary>
    public partial class Collationer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }

    }
}
