using System;

namespace YasunliESModel.Models
{
    public partial class ViewReworkOut
    {
        public string ReworkID { get; set; }
        public string BarcodeID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string MainModel { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<int> Qty { get; set; }
        public string ToolingID { get; set; }
        public string InjectionCode { get; set; }
        public string PICRework { get; set; }
    }
}
