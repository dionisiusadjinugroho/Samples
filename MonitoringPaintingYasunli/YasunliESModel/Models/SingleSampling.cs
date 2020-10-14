using System;

namespace YasunliESModel.Models
{
    public partial class SingleSampling
    {
        public string LetterCode { get; set; }
        public Nullable<int> SamplingSize { get; set; }
        public decimal AQL { get; set; }
        public Nullable<int> RejectQty { get; set; }
        public int SingleSamplingId { get; set; }
    }
}
