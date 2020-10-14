using System;

namespace YasunliESModel.Models
{
    public partial class CMMHeader
    {
        public int JobId { get; set; }
        public string ItemId { get; set; }
        public string LotNo { get; set; }
        public Nullable<bool> CMMPass { get; set; }
        public Nullable<System.DateTime> MeasuringDate { get; set; }
        public string MeasuredBy { get; set; }
    }
}
