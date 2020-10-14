using System;

namespace YasunliESModel.Models
{
    public partial class AdjustStockHistory
    {
        public int Id { get; set; }
        public string BarcodeID { get; set; }
        public Nullable<int> QtyBefore { get; set; }
        public Nullable<int> QtyAfter { get; set; }
        public Nullable<System.DateTime> ChangeDate { get; set; }
        public string Change_by { get; set; }
        public string Alasan { get; set; }
    }
}
