using System;

namespace YasunliESModel.Models
{
    public partial class BoxLabelRusak
    {
        public int BoxLabelRusakID { get; set; }
        public string BoxNo { get; set; }
        public string BoxID { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<System.DateTime> DateSubmit { get; set; }
        public string PlantID { get; set; }
    }
}
