using System;

namespace YasunliESModel.Models
{
    public partial class CMM
    {
        public int CMMID { get; set; }
        public string ItemID { get; set; }
        public string Karakter { get; set; }
        public Nullable<decimal> upperlimit { get; set; }
        public Nullable<decimal> lowerlimit { get; set; }
        public string standard { get; set; }
        public string Grade { get; set; }
        public string DrawingPage { get; set; }
        public string AddressNo { get; set; }
        public string AddressAlpha { get; set; }
        public string Rev { get; set; }
        public string SymbolNote { get; set; }
        public string MeasureDev1 { get; set; }
        public string MeasureDev2 { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
