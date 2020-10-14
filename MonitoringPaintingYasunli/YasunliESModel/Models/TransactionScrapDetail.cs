using System;

namespace YasunliESModel.Models
{
    public partial class TransactionScrapDetail
    {
        public string DetailID { get; set; }
        public string TransactionScrapNo { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> GrossWeight { get; set; }
        public string UoMID { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
    }
}
