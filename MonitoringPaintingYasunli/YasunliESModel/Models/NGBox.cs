using System;

namespace YasunliESModel.Models
{
    public partial class NGBox
    {
        public int Id { get; set; }
        public string BoxNo { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string NoJobId { get; set; }
    }
}
