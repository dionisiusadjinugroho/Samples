using System;

namespace YasunliESModel.Models
{
    public partial class RequestOrder
    {
        public string RequestID { get; set; }
        public string DivisionID { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string SppNo { get; set; }
        public Nullable<short> Status { get; set; }
        public string PlantID { get; set; }
        public string FromPlant { get; set; }
    }
}
