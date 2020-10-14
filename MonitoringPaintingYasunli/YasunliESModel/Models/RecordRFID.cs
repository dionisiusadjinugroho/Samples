using System;

namespace YasunliESModel.Models
{
    public partial class RecordRFID
    {
        public int IEIBoxID { get; set; }
        public string RFID { get; set; }
        public string BarcodeID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string POSTJson { get; set; }
        public int ID { get; set; }
    }
}
