using System;

namespace YasunliESModel.Models
{
    public partial class MaterialPallet
    {
        public string MaterialPalletId { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public string ItemId { get; set; }
        public string Location { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string LotNo { get; set; }
        public string ReceivingNo { get; set; }
    }
}
