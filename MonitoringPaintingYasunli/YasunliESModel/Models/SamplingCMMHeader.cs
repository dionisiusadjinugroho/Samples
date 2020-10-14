using System;

namespace YasunliESModel.Models
{
    public partial class SamplingCMMHeader
    {
        public int JobNo { get; set; }
        public string ItemID { get; set; }
        public string BarcodeID { get; set; }
        public Nullable<System.DateTime> ScanTime { get; set; }
        public string UserId { get; set; }
        public Nullable<bool> Finalized { get; set; }
    }
}
