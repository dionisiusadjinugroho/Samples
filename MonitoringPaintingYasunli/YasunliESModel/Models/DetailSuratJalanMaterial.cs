using System;

namespace YasunliESModel.Models
{
    public partial class DetailSuratJalanMaterial
    {
        public int DetailSuratJalanMaterialID { get; set; }
        public string SuratJalanMaterialID { get; set; }
        public string Barcode { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string LotNo { get; set; }
        public Nullable<System.DateTime> ScanTime { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
    }
}
