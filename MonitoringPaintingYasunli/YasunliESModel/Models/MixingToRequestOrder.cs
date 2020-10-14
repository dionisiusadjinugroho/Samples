using System;

namespace YasunliESModel.Models
{
    public partial class MixingToRequestOrder
    {
        public int MixingToRequestOrderID { get; set; }
        public string RequestOrderID { get; set; }
        public string SackID { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<System.DateTime> ScanTime { get; set; }
        public string MixingID { get; set; }
        public string NIK { get; set; }
    }
}
