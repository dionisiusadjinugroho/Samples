using System;

namespace YasunliESModel.Models
{
    public partial class ItemForecast
    {
        public System.Guid ItemForecastId { get; set; }
        public string ItemId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string CustomerId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
