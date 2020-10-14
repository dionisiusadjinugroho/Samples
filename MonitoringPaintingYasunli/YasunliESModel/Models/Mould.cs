using System;

namespace YasunliESModel.Models
{
    public partial class Mould
    {
        public string MouldID { get; set; }
        public string CustomerID { get; set; }
        public string MachineID { get; set; }
        public string ClampingForce { get; set; }
        public Nullable<bool> Status { get; set; }
        public string MouldCode { get; set; }
        public string MouldName { get; set; }
        public string ToolingID { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<bool> HotRunner { get; set; }
        public Nullable<decimal> SprueDiameter { get; set; }
        public Nullable<decimal> SprueRadius { get; set; }
        public Nullable<bool> TriplePlate { get; set; }
        public string Cavity { get; set; }
        public string Maker { get; set; }
        public Nullable<System.DateTime> ComDate { get; set; }
        public string Model { get; set; }
        public Nullable<int> Overhaul { get; set; }
        public string Gate { get; set; }
        public Nullable<bool> FamilyMould { get; set; }
    }
}
