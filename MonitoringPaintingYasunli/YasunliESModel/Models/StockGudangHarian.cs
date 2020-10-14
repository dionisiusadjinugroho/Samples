using System;

namespace YasunliESModel.Models
{
    public partial class StockGudangHarian
    {
        public int CountID { get; set; }
        public string PlantID { get; set; }
        public Nullable<System.DateTime> Tanggal { get; set; }
        public string ItemID { get; set; }
        public Nullable<int> Qty { get; set; }
    }
}
