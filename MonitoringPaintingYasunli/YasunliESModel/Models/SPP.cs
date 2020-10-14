using System;

namespace YasunliESModel.Models
{
    public partial class SPP
    {
        public string SPPNo { get; set; }
        public string MachineID { get; set; }
        public string CustomerID { get; set; }
        public string PlantID { get; set; }
        public string MouldID { get; set; }
        public string ToolingID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string Cavity { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<short> Status { get; set; }
        public string ItemCode { get; set; }
        public string Created_By { get; set; }
        public string Keterangan { get; set; }
        public Nullable<System.DateTime> UpTime { get; set; }
        public Nullable<System.DateTime> TechVerDate { get; set; }
        public string Technisi { get; set; }
        public string VerNumber { get; set; }
        public string ClosePacking { get; set; }
        public Nullable<int> Aktifitas { get; set; }
    }
}
