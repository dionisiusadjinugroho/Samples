using System;

namespace YasunliESModel.Models
{
    public partial class ViewMouldSparepartCost
    {
        public int JobOrderID { get; set; }
        public string PartName { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
    }
}
