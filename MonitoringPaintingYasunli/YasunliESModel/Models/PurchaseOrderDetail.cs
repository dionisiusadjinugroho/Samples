using System;

namespace YasunliESModel.Models
{
    public partial class PurchaseOrderDetail
    {
        public int DetailID { get; set; }
        public string PONo { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> PriceD { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string MEMONo { get; set; }
        public virtual Item Item { get; set; }
        public virtual Item Item1 { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
