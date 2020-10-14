using System;

namespace YasunliESModel.Models
{
    public partial class ItemForecastHistory
    {
        public System.Guid ItemForecastHistoryId { get; set; }
        public string ItemId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string CustomerId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
