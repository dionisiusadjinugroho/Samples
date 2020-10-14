using System;

namespace YasunliESModel.Models
{
    public partial class DetailOverpacking
    {
        public int IDDetailOverpacking { get; set; }
        public string IDOverpacking { get; set; }
        public string BarcodeID { get; set; }
        public string ItemID { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<System.DateTime> scan_date { get; set; }
    }
}
