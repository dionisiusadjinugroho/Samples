using System;

namespace YasunliESModel.Models
{
    public partial class ViewBQICSAlertList
    {
        public string LotNo { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string MainModel { get; set; }
        public string SPPNo { get; set; }
        public Nullable<System.DateTime> MulaiSPP { get; set; }
        public string InspectionResult { get; set; }
        public Nullable<System.DateTime> TutupSPP { get; set; }
        public string Note { get; set; }
        public string Keterangan { get; set; }
        public string X { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public int QtyGudang { get; set; }
        public int QtyKeluarDelivery { get; set; }
    }
}
