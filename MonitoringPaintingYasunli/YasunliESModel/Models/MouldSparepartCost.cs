using System;

namespace YasunliESModel.Models
{
    public partial class MouldSparepartCost
    {
        public int MouldSparepartCostId { get; set; }
        public Nullable<int> SparepartId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}
