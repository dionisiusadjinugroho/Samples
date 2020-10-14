using System;

namespace YasunliESModel.Models
{
    public partial class KanbanException
    {
        public string ItemId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
