using System;

namespace YasunliESModel.Models
{
    public partial class HistoryBoxDelivery
    {
        public int HistoryBoxDeliveryID { get; set; }
        public string RentalID { get; set; }
        public string DriverID { get; set; }
        public string CustomerID { get; set; }
        public string PlantID { get; set; }
        public string DivisionID { get; set; }
        public string NoPolisi { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
    }
}
