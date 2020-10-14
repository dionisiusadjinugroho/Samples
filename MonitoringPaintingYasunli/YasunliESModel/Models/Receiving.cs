using System;

namespace YasunliESModel.Models
{
    public partial class Receiving
    {
        public string ReceivingID { get; set; }
        public string VendorID { get; set; }
        public string POID { get; set; }
        public string SuratJalanNo { get; set; }
        public Nullable<System.DateTime> Tanggal { get; set; }
        public string PlantID { get; set; }
    }
}
