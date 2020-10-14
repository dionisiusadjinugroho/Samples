using System;

namespace YasunliESModel.Models
{
    public partial class StockUpload
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> StockAwal { get; set; }
        public Nullable<decimal> StockMasuk { get; set; }
        public Nullable<decimal> StockKeluar { get; set; }
        public Nullable<decimal> StockAkhir { get; set; }
        public string Plant { get; set; }
        public int ID { get; set; }
    }
}
