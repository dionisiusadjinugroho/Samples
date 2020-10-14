using System;

namespace YasunliESModel.Models
{
    public partial class BoxHilang
    {
        public int BoxHilangID { get; set; }
        public string BoxNo { get; set; }
        public string BoxID { get; set; }
        public Nullable<int> HistoryBoxReturnID { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
