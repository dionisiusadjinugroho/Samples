using System;

namespace YasunliESModel.Models
{
    public partial class Package
    {
        public string PackageID { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<int> Revisi { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public string PlantID { get; set; }
        public string Created_By { get; set; }
        public string Sended_By { get; set; }
        public string OverRide_By { get; set; }
        public string Location { get; set; }
        public string Checked_By { get; set; }
        public string Authorized_By { get; set; }
        public string FinishedOut { get; set; }
        public string PrintBy { get; set; }
        public Nullable<System.DateTime> PrintDate { get; set; }
    }
}
