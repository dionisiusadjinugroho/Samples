using System;

namespace YasunliESModel.Models
{
    public partial class JobWorkshopHistory
    {
        public int JobHistoryId { get; set; }
        public Nullable<int> JobId { get; set; }
        public string StatusNow { get; set; }
        public string StatusNew { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string EmployeeId { get; set; }
    }
}
