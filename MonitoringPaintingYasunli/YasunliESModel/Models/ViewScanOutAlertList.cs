using System;

namespace YasunliESModel.Models
{
    public partial class ViewScanOutAlertList
    {
        public Nullable<long> NO { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string MainModel { get; set; }
        public Nullable<System.DateTime> JamSave { get; set; }
        public string Gudang { get; set; }
        public Nullable<System.DateTime> JamGudang { get; set; }
        public string QC { get; set; }
        public Nullable<System.DateTime> JamQC { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Tujuan { get; set; }
        public string Keterangan { get; set; }
    }
}
