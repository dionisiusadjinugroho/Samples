using System;

namespace YasunliESModel.Models
{
    public partial class MixingHeader
    {
        public string MixingId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string MaterialType { get; set; }
        public string Description { get; set; }
        public Nullable<short> Status { get; set; }
        public string PlantID { get; set; }
        public string NIK { get; set; }
    }
}
