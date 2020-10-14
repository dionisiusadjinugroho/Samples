using System;

namespace YasunliESModel.Models
{
    public partial class SPQ
    {
        public string SPQID { get; set; }
        public string ItemID { get; set; }
        public string CustomerID { get; set; }
        public string BoxTypeID { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<decimal> BeratBox { get; set; }
        public Nullable<decimal> VolumeBox { get; set; }
        public string TrayType { get; set; }
        public Nullable<int> TrayQty { get; set; }
    }
}
