using System;

namespace YasunliESModel.Models
{
    public partial class Rework
    {
        public string ReworkID { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<int> Revisi { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public string PlantID { get; set; }
        public string Created_By { get; set; }
        public string Sended_By { get; set; }
    }
}
