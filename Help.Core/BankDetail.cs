

namespace Help.Domain
{
   /// <summary>
   /// This class represents bank details 
   /// that can be associated with an Individual or
   /// Organization account
   /// </summary>
     public partial class BankDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
    }
}
