using System;

namespace YasunliESModel.Models
{
    public partial class SacksDetail
    {
        public string SackId { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string DocumentNo { get; set; }
        public string Type { get; set; }
        public string FromDocumentNo { get; set; }
        public string PlantID { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
    }
}