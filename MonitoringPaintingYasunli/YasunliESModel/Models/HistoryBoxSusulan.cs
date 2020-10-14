using System;

namespace YasunliESModel.Models
{
    public partial class HistoryBoxSusulan
    {
        public int HistoryBoxSusulanID { get; set; }
        public int HistoryBoxReturnID { get; set; }
        public int HistoryBoxLeverlansirID { get; set; }
        public string EmployeeId { get; set; }
        public string BoxNo { get; set; }
        public string BoxID { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
    }
}
