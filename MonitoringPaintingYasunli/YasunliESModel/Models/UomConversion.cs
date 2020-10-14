using System;

namespace YasunliESModel.Models
{
    public partial class UomConversion
    {
        public System.Guid UoMConversionID { get; set; }
        public string UoMID { get; set; }
        public string UnitToConvert { get; set; }
        public string UnitEquivalent { get; set; }
        public Nullable<decimal> MultiplicationFactor { get; set; }
    }
}
