using System;

namespace YasunliESModel.Models
{
    public partial class LimitSampleDetail
    {
        public int LimitSampleDetailId { get; set; }
        public string LimitSampleId { get; set; }
        public string UsedBy { get; set; }
        public Nullable<System.DateTime> UsedDate { get; set; }
    }
}
