using System;

namespace YasunliESModel.Models
{
    public partial class TempLocationGudang
    {
        public int ID { get; set; }
        public string BarcodeID { get; set; }
        public string Location { get; set; }
        public string Pairing_By { get; set; }
        public DateTime? ScanDate { get; set; }
        public string NextPosition { get; set; }
        public string RFID { get; set; }

    }
}
