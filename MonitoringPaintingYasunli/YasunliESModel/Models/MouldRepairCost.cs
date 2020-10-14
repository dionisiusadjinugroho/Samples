using System;

namespace YasunliESModel.Models
{
    public partial class MouldRepairCost
    {
        public int MouldCostId { get; set; }
        public Nullable<int> JobId { get; set; }
        public Nullable<decimal> DesignWH { get; set; }
        public Nullable<decimal> DesignMP { get; set; }
        public Nullable<decimal> CAMWH { get; set; }
        public Nullable<decimal> CAMMP { get; set; }
        public Nullable<decimal> CNCWH { get; set; }
        public Nullable<decimal> CNCMP { get; set; }
        public Nullable<decimal> WireCutWH { get; set; }
        public Nullable<decimal> WireCutMP { get; set; }
        public Nullable<decimal> EDMWH { get; set; }
        public Nullable<decimal> EDMMP { get; set; }
        public Nullable<decimal> WieldingWH { get; set; }
        public Nullable<decimal> WieldingMP { get; set; }
        public Nullable<decimal> SpottingMP { get; set; }
        public Nullable<decimal> SpottingWH { get; set; }
        public Nullable<decimal> PolishingMP { get; set; }
        public Nullable<decimal> PlishingWH { get; set; }
        public Nullable<decimal> SandblastWH { get; set; }
        public Nullable<decimal> SandblastMP { get; set; }
        public Nullable<decimal> DiasassemblyWH { get; set; }
        public Nullable<decimal> DiasassemblyMP { get; set; }
        public Nullable<decimal> AssemblyWH { get; set; }
        public Nullable<decimal> AssemblyMP { get; set; }
        public Nullable<decimal> WeldingLaserWH { get; set; }
        public Nullable<decimal> WeldingLaserMP { get; set; }
        public Nullable<decimal> HardeningWH { get; set; }
        public Nullable<decimal> HardeningMP { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<System.DateTime> SaveDate { get; set; }
        public Nullable<decimal> DryIceWH { get; set; }
        public Nullable<decimal> DryIceMP { get; set; }
        public Nullable<decimal> BubutManualWH { get; set; }
        public Nullable<decimal> BubutManualMP { get; set; }
        public Nullable<decimal> RadialBorWH { get; set; }
        public Nullable<decimal> RadialBorMP { get; set; }
        public Nullable<decimal> MillingManualWH { get; set; }
        public Nullable<decimal> MillingManualMP { get; set; }
        public Nullable<decimal> CNCBubutWH { get; set; }
        public Nullable<decimal> CNCBubutMP { get; set; }
        public Nullable<decimal> GrindingWH { get; set; }
        public Nullable<decimal> GrindingMP { get; set; }
    }
}
