using System;

namespace YasunliESModel.Models
{
    public partial class MixingDetail
    {
        public System.Guid MixingDetailId { get; set; }
        public string MixingId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string SackId { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> ScanTime { get; set; }
        public string DocumentNo { get; set; }
    }
}
