using System;

namespace YasunliESModel.Models
{
    public partial class STOGudangReady
    {
        public int ID { get; set; }
        public string CustomerBarcode { get; set; }
        public string BarcodeID { get; set; }
        public string ScanBy { get; set; }
        public string Location { get; set; }
        public DateTime ScanDate { get; set; }


    }
}
