using System;

namespace YasunliESModel.Models
{
    public partial class MouldHistory
    {
        public System.Guid MouldHistoryID { get; set; }
        public string MouldID { get; set; }
        public string ToolingID { get; set; }
        public Nullable<int> JobOrder { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<bool> Repair { get; set; }
        public string JobDetail { get; set; }
    }
}
