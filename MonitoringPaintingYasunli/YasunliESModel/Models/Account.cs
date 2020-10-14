namespace YasunliESModel.Models
{
    public partial class Account
    {
        public string AccountId { get; set; }
        public int AccountType { get; set; }
        public string AccountName { get; set; }
        public string ParentId { get; set; }
        public string Hierarchy { get; set; }
        public string Description { get; set; }
        public bool IsLastChild { get; set; }
    }
}
