using System;

namespace YasunliESModel.Models
{
    public partial class MixingMachine
    {
        public System.Guid MixingMachineId { get; set; }
        public string MixingId { get; set; }
        public string SackId { get; set; }
        public string SppNo { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    }
}
