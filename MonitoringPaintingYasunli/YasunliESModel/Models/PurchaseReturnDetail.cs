using System;

namespace YasunliESModel.Models
{
    public partial class PurchaseReturnDetail
    {
        public string DetailID { get; set; }
        public string PurchaseReturnNo { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string UoMID { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> PriceD { get; set; }
    }
}
