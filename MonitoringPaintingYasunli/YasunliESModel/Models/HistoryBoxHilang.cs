using System;

namespace YasunliESModel.Models
{
    public partial class HistoryBoxHilang
    {
        public int HistoryBoxHilangID { get; set; }
        public Nullable<int> HistoryBoxReturnID { get; set; }
        public string BoxNo { get; set; }
        public string BoxID { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<System.DateTime> ScanTime { get; set; }
    }
}
