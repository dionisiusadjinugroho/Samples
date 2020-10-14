using System;

namespace YasunliESModel.Models
{
    public partial class SamplingCMMDetail
    {
        public int SamplingCMMDetailId { get; set; }
        public string NPK { get; set; }
        public string BarcodeID { get; set; }
        public string Char { get; set; }
        public string Result { get; set; }
        public Nullable<int> JobNo { get; set; }
        public string UL { get; set; }
        public string LL { get; set; }
        public string STD { get; set; }
    }
}
