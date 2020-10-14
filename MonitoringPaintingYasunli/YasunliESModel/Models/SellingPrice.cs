using System;

namespace YasunliESModel.Models
{
    public partial class SellingPrice
    {
        public int Id { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public string ItemId { get; set; }
        public string CustomerId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> Effective_Date { get; set; }
        public string Created_By { get; set; }
        public Nullable<decimal> ServicePrice { get; set; }
        public Nullable<decimal> MaterialPrice { get; set; }
    }
}
