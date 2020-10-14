using System;
using System.Collections.Generic;

namespace YasunliESModel.Models
{
    public partial class Item
    {
        public Item()
        {
            this.MaterialAdjustmentDetails = new List<MaterialAdjustmentDetail>();
            this.MaterialAdjustmentDetails1 = new List<MaterialAdjustmentDetail>();
            this.MaterialOutDetails = new List<MaterialOutDetail>();
            this.MaterialOutDetails1 = new List<MaterialOutDetail>();
            this.MaterialReturnDetail1 = new List<MaterialReturnDetail1>();
            this.MaterialReturnDetail11 = new List<MaterialReturnDetail1>();
            this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            this.PurchaseOrderDetails1 = new List<PurchaseOrderDetail>();
        }

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
        public string SAPItemId { get; set; }
        public string CustomerPrefixx { get; set; }
        public string SubCategory { get; set; }
        public virtual ICollection<MaterialAdjustmentDetail> MaterialAdjustmentDetails { get; set; }
        public virtual ICollection<MaterialAdjustmentDetail> MaterialAdjustmentDetails1 { get; set; }
        public virtual ICollection<MaterialOutDetail> MaterialOutDetails { get; set; }
        public virtual ICollection<MaterialOutDetail> MaterialOutDetails1 { get; set; }
        public virtual ICollection<MaterialReturnDetail1> MaterialReturnDetail1 { get; set; }
        public virtual ICollection<MaterialReturnDetail1> MaterialReturnDetail11 { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails1 { get; set; }
    }
}
