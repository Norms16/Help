

namespace Help.Domain
{
    /// <summary>
    /// Category to which a Donor belong
    /// i.e 
    /// 1.Individual,
    /// 2.Funding Agent,
    /// 3.Government and 
    /// 4.Others
    /// </summary>
   public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
