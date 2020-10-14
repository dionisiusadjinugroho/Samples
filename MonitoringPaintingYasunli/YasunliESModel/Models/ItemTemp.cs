using System;

namespace YasunliESModel.Models
{
    public partial class ItemTemp
    {
        public string ItemID { get; set; }
        public string UoMID { get; set; }
        public string UomItemWeight { get; set; }
        public string UomItemRunner { get; set; }
        public string MachineGroupID { get; set; }
        public string VendorID { get; set; }
        public string CustomerID { get; set; }
        public string MouldID { get; set; }
        public string DivisionID { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> ItemWeight { get; set; }
        public Nullable<decimal> RunnerWeight { get; set; }
        public Nullable<decimal> CycleTime { get; set; }
        public string ItemComponent { get; set; }
        public string Category { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> UsageStop { get; set; }
        public string VersionInfo { get; set; }
        public Nullable<System.DateTime> ValidStart { get; set; }
        public Nullable<System.DateTime> ValidUntil { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string MachineName { get; set; }
        public string MDI { get; set; }
        public string MainModel { get; set; }
        public string MaterialType { get; set; }
        public Nullable<System.DateTime> close_date { get; set; }
        public string closed_by { get; set; }
        public string Colour { get; set; }
        public string Product { get; set; }
        public string Side { get; set; }
        public string QualityLevel { get; set; }
        public Nullable<decimal> ManPower { get; set; }
        public Nullable<decimal> AQL { get; set; }
        public string Gate { get; set; }
    }
}
