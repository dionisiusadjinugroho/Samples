using System;

namespace YasunliESModel.Models
{
    public partial class EngineeringJobDetail
    {
        public int EngineeringJobDetailId { get; set; }
        public Nullable<int> JobId { get; set; }
        public string Material { get; set; }
        public Nullable<decimal> MaterialUsage { get; set; }
        public Nullable<decimal> ManPower { get; set; }
        public Nullable<decimal> WorkHour { get; set; }
    }
}
