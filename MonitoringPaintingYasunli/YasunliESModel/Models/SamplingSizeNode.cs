using System;

namespace YasunliESModel.Models
{
    public partial class SamplingSizeNode
    {
        public string SamplingLevel { get; set; }
        public Nullable<int> LotSizeMin { get; set; }
        public Nullable<int> LotSizeMax { get; set; }
        public string LetterCode { get; set; }
    }
}
