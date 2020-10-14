using System;

namespace YasunliESModel.Models
{
    public partial class MMDiff2018
    {
        public int MouldCostId { get; set; }
        public Nullable<int> JobId { get; set; }
        public decimal DesignWH { get; set; }
        public decimal DesignMP { get; set; }
        public decimal CAMWH { get; set; }
        public decimal CAMMP { get; set; }
        public decimal CNCWH { get; set; }
        public decimal CNCMP { get; set; }
        public decimal WireCutWH { get; set; }
        public decimal WireCutMP { get; set; }
        public decimal EDMWH { get; set; }
        public decimal EDMMP { get; set; }
        public decimal WieldingWH { get; set; }
        public decimal WieldingMP { get; set; }
        public decimal SpottingMP { get; set; }
        public decimal SpottingWH { get; set; }
        public decimal PolishingMP { get; set; }
        public decimal PlishingWH { get; set; }
        public decimal SandblastWH { get; set; }
        public decimal SandblastMP { get; set; }
        public decimal DiasassemblyWH { get; set; }
        public decimal DiasassemblyMP { get; set; }
        public decimal AssemblyWH { get; set; }
        public decimal AssemblyMP { get; set; }
        public decimal WeldingLaserWH { get; set; }
        public decimal WeldingLaserMP { get; set; }
        public decimal HardeningWH { get; set; }
        public decimal HardeningMP { get; set; }
        public string EmployeeId { get; set; }
        public System.DateTime SaveDate { get; set; }
        public decimal DryIceWH { get; set; }
        public decimal DryIceMP { get; set; }
        public decimal BubutManualWH { get; set; }
        public decimal BubutManualMP { get; set; }
        public decimal RadialBorWH { get; set; }
        public decimal RadialBorMP { get; set; }
        public decimal MillingManualWH { get; set; }
        public decimal MillingManualMP { get; set; }
        public decimal CNCBubutWH { get; set; }
        public decimal CNCBubutMP { get; set; }
        public decimal GrindingWH { get; set; }
        public decimal GrindingMP { get; set; }
        public string MouldCode { get; set; }
        public string MouldName { get; set; }
        public string Tooling { get; set; }
        public string Model { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
    }
}
