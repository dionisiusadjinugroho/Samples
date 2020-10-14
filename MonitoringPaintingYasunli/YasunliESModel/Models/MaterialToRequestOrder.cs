using System;

namespace YasunliESModel.Models
{
    public partial class MaterialToRequestOrder
    {
        public System.Guid MaterialToMixingId { get; set; }
        public string RequestOrderId { get; set; }
        public string ItemId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
