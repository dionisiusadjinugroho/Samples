using System;

namespace YasunliESModel.Models
{
    public partial class ViewPORemainAccounting
    {
        public string PONo { get; set; }
        public Nullable<System.DateTime> PoDate { get; set; }
        public string VendorName { get; set; }
        public string PoType { get; set; }
        public string Plant { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public decimal QtyReceive { get; set; }
        public decimal SisaPO { get; set; }
        public string KodeCurrency { get; set; }
        public Nullable<decimal> Harga { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> TotalPriceReceive { get; set; }
        public string StatusPO { get; set; }
    }
}
