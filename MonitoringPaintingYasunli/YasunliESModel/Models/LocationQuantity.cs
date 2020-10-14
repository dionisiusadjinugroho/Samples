using System;

namespace YasunliESModel.Models
{
    public partial class LocationQuantity
    {
        public string LocationID { get; set; }
        public string PlantID { get; set; }
        public Nullable<bool> Status { get; set; }
        public string DocumentID { get; set; }
        public Nullable<System.DateTime> LastEdited { get; set; }
    }
}
