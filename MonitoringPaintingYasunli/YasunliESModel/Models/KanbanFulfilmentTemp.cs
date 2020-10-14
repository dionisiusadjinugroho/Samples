using System;

namespace YasunliESModel.Models
{
    public partial class KanbanFulfilmentTemp
    {
        public int KanbanFulfilmentId { get; set; }
        public string BarcodeId { get; set; }
        public string KanbanId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public string SendedBy { get; set; }
        public string CheckedBy { get; set; }
        public string CreatedBy { get; set; }
    }
}
