using System;

namespace YasunliESModel.Models
{
    public partial class Sparepart2ndProcess
    {
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public string RequestID { get; set; }
        public string SackID { get; set; }
        public Nullable<int> Qty { get; set; }
        public string DocumentNo { get; set; }
        public string Type { get; set; }
        public string PlantID { get; set; }
        public string Divisi { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
    }
}
