using System;

namespace YasunliESModel.Models
{
    public partial class DetailHistoryBoxReturn
    {
        public int DetailHistoryBoxReturnID { get; set; }
        public Nullable<int> HistoryBoxReturnID { get; set; }
        public string BoxNo { get; set; }
        public string BoxID { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
    }
}
