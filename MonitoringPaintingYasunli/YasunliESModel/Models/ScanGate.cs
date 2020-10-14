using System;

namespace YasunliESModel.Models
{
    public partial class ScanGate
    {
        public int GateScanID { get; set; }
        public Nullable<int> TransitId { get; set; }
        public string BarcodeID { get; set; }
        public string BarcodeScannerHWID { get; set; }
        public Nullable<System.DateTime> DateScan { get; set; }
    }
}
