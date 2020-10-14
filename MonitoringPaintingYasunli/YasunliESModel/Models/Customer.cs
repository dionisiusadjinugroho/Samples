using System;

namespace YasunliESModel.Models
{
    public partial class Customer
    {
        public string CustomerID { get; set; }
        public string PaymentTermID { get; set; }
        public string DeliveryTermID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPrefix { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string NPWP { get; set; }
        public string SKEPKB { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ICPExpiryDate { get; set; }
        public Nullable<bool> masterList { get; set; }
        public string NoIzinTPB { get; set; }
    }
}
