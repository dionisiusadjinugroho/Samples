using System;

namespace YasunliESModel.Models
{
    public partial class Box
    {
        public string BoxNo { get; set; }
        public string BoxID { get; set; }
        public string BoxTypeID { get; set; }
        public string CustomerID { get; set; }
        public string DivisionID { get; set; }
        public string PlantID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public Nullable<int> BoxOut { get; set; }
        public Nullable<int> BoxIn { get; set; }
        public Nullable<bool> Isi { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
