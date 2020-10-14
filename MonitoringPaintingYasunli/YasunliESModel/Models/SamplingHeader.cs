using System;

namespace YasunliESModel.Models
{
    public partial class SamplingHeader
    {
        public int JobNo { get; set; }
        public string ItemID { get; set; }
        public string BarcodeID { get; set; }
        public Nullable<System.DateTime> ScanTime { get; set; }
        public string UserId { get; set; }
        public Nullable<bool> Finalized { get; set; }
        public string DocumentNo { get; set; }
        public string UserGdr { get; set; }
    }
}
