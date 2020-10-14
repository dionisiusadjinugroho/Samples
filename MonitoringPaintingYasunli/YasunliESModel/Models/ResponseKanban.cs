using System;

namespace YasunliESModel.Models
{
    public partial class ResponseKanban
    {
        public System.Guid KanbanResponseId { get; set; }
        public string RequestID { get; set; }
        public Nullable<int> QtyKeluar { get; set; }
        public Nullable<int> QtyRemain { get; set; }
    }
}
