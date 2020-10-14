using System;

namespace YasunliESModel.Models
{
    public partial class ProductionCheckListNGDetail
    {
        public System.Guid ProductionCheckLisNGDetailtId { get; set; }
        public Nullable<System.Guid> ProductionCheckListId { get; set; }
        public string NGType { get; set; }
        public Nullable<System.TimeSpan> TimeRange { get; set; }
        public Nullable<int> Qty { get; set; }
    }
}
