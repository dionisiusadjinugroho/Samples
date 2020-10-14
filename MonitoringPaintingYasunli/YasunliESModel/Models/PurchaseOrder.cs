using System;
using System.Collections.Generic;

namespace YasunliESModel.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

        public string PONo { get; set; }
        public string PlantID { get; set; }
        public string VendorID { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public string Attn { get; set; }
        public string Description { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<int> TaxType { get; set; }
        public string VoidDescription { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string VoidBy { get; set; }
        public Nullable<System.DateTime> VoidDate { get; set; }
        public string ClosedBy { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public string PoType { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
