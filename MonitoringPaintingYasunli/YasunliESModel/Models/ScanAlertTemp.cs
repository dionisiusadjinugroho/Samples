using System;

namespace YasunliESModel.Models
{
    public partial class ScanAlertTemp
    {
        public int ScanAlertId { get; set; }
        public Nullable<System.DateTime> AlertDate { get; set; }
        public string DocumentNo { get; set; }
        public string RequestBy { get; set; }
        public string Division { get; set; }
        public string ItemId { get; set; }
        public string Model { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Tujuan { get; set; }
    }
}
