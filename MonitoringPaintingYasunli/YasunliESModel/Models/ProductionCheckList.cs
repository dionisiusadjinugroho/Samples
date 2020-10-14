using System;

namespace YasunliESModel.Models
{
    public partial class ProductionCheckList
    {
        public System.Guid ProductionCheckListId { get; set; }
        public string SppNo { get; set; }
        public Nullable<short> Shift { get; set; }
        public Nullable<int> Target { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string ItemId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> StartHour { get; set; }
        public Nullable<System.DateTime> StopHour { get; set; }
        public Nullable<decimal> WorkHour { get; set; }
    }
}
