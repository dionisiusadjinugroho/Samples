using System;

namespace YasunliESModel.Models
{
    public partial class Transit
    {
        public int Id { get; set; }
        public string Gate { get; set; }
        public string DriverID { get; set; }
        public string NoPolisi { get; set; }
        public string CustomerID { get; set; }
        public string BarcodeScannerHWID { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Closed_By { get; set; }
        public Nullable<int> Printed { get; set; }
        public string Adm { get; set; }
    }
}
