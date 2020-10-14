using System;

namespace YasunliESModel.Models
{
    public partial class PartTransactionInjection
    {
        public string BarcodeID { get; set; }
        public string PlantID { get; set; }
        public string Position { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public Nullable<int> Qty { get; set; }
        public string NextPosition { get; set; }
        public string LastScanPosition { get; set; }
        public Nullable<byte> Status { get; set; }
        public string Scan_By { get; set; }
        public string LastPosition { get; set; }
        public string Discontinue_Authorize { get; set; }
        public string return_mark { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> is_ES { get; set; }
        public Nullable<int> pecahan { get; set; }
        public string QCOut { get; set; }
    }
}
