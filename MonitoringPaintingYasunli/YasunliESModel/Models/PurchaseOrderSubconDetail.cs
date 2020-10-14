using System;

namespace YasunliESModel.Models
{
    public partial class PurchaseOrderSubconDetail
    {
        public int DetailID { get; set; }
        public string POSubconNo { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> PriceD { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
    }
}
