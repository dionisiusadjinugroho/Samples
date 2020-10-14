using System;

namespace YasunliESModel.Models
{
    public partial class HistoryHoldQC
    {
        public int HistoryHoldQCID { get; set; }
        public string HoldQCID { get; set; }
        public string BarcodeID { get; set; }
        public string Kategori { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string admID { get; set; }
        public string plannerID { get; set; }
        public Nullable<System.DateTime> hold_date { get; set; }
        public Nullable<System.DateTime> release_date { get; set; }
    }
}
