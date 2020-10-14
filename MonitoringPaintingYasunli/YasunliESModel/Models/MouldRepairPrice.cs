using System;

namespace YasunliESModel.Models
{
    public partial class MouldRepairPrice
    {
        public int Id { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public string ItemProcess { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> Effective_Date { get; set; }
        public string Created_By { get; set; }
    }
}
