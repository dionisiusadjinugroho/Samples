using System;

namespace YasunliESModel.Models
{
    public partial class DetailHistoryBoxDelivery
    {
        public int DetailHistoryBoxDeliveryID { get; set; }
        public Nullable<int> HistoryBoxDeliveryID { get; set; }
        public string BoxNo { get; set; }
        public string BoxID { get; set; }
        public Nullable<System.DateTime> ScanTime { get; set; }
    }
}
