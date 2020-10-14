using System;

namespace YasunliESModel.Models
{
    public partial class Kanban
    {
        public int KanbanId { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string CustomerId { get; set; }
        public Nullable<System.DateTime> TransitTime { get; set; }
        public string KanbanNo { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
    }
}
