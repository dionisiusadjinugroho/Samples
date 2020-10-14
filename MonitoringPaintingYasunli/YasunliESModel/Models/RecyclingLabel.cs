using System;

namespace YasunliESModel.Models
{
    public partial class RecyclingLabel
    {
        public int RecyclingLabelID { get; set; }
        public string RecycleId { get; set; }
        public string SackID { get; set; }
        public Nullable<int> Tipe { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
    }
}
