using System;
using System.Collections.Generic;

namespace YasunliESModel.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            this.MaterialReceivings = new List<MaterialReceiving>();
            this.PurchaseOrders = new List<PurchaseOrder>();
        }

        public string VendorID { get; set; }
        public string PaymentTermID { get; set; }
        public string DeliveryTermID { get; set; }
        public string VendorName { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string NoIzinTPB { get; set; }
        public string NPWP { get; set; }
        public virtual ICollection<MaterialReceiving> MaterialReceivings { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
