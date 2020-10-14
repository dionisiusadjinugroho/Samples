using System;

namespace YasunliESModel.Models
{
    public partial class MouldSparepart1
    {
        public int Id { get; set; }
        public string PartID { get; set; }
        public string PartName { get; set; }
        public string MainSupplier { get; set; }
        public string UnitMeasurement { get; set; }
        public Nullable<System.DateTime> InputDate { get; set; }
        public string InputUser { get; set; }
    }
}
