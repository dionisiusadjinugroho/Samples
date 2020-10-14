using System;

namespace YasunliESModel.Models
{
    public partial class BoxLocation
    {
        public int BoxLocationID { get; set; }
        public string BoxID { get; set; }
        public string PlantID { get; set; }
        public string DivisionID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<System.DateTime> Dates { get; set; }
    }
}
