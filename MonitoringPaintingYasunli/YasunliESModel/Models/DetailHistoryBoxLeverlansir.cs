using System;

namespace YasunliESModel.Models
{
    public partial class DetailHistoryBoxLeverlansir
    {
        public int DetailHistoryBoxLeverlansirID { get; set; }
        public Nullable<int> HistoryBoxLeverlansirID { get; set; }
        public string BoxID { get; set; }
        public string BoxNo { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
    }
}
