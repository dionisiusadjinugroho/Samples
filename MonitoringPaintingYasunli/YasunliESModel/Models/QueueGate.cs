using System;

namespace YasunliESModel.Models
{
    public partial class QueueGate
    {
        public System.Guid QueueId { get; set; }
        public string BarcodeId { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public Nullable<System.DateTime> SaveDate { get; set; }
        public string QCScan { get; set; }
        public string WHScan { get; set; }
        public Nullable<System.DateTime> QCScanDate { get; set; }
        public Nullable<System.DateTime> WHScanDate { get; set; }
    }
}
