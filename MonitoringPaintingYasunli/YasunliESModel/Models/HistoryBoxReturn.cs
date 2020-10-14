using System;

namespace YasunliESModel.Models
{
    public partial class HistoryBoxReturn
    {
        public int HistoryBoxReturnID { get; set; }
        public string CustomerID { get; set; }
        public string RentalID { get; set; }
        public string DriverID { get; set; }
        public string NoPolisi { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<System.DateTime> DateReturn { get; set; }
        public string ReferenceCode { get; set; }
    }
}
