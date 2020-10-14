using System;

namespace YasunliESModel.Models
{
    public partial class BQICSAlertList
    {
        public string LotNo { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string MainModel { get; set; }
        public string SppNo { get; set; }
        public Nullable<System.DateTime> MulaiSPP { get; set; }
        public Nullable<System.DateTime> TutupSPP { get; set; }
        public string Keterangan { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public int QtyGudang { get; set; }
        public int QtyKeluarDelivery { get; set; }
        public string Note { get; set; }
    }
}
