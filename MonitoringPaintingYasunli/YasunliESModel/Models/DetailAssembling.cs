using System;

namespace YasunliESModel.Models
{
    public partial class DetailAssembling
    {
        public int DetailAssemblingId { get; set; }
        public string AssemblingId { get; set; }
        public string BarcodeID { get; set; }
        public string ItemID { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<System.DateTime> scan_date { get; set; }
    }
}
