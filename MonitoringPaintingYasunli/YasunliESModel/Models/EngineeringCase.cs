using System;

namespace YasunliESModel.Models
{
    public partial class EngineeringCase
    {
        public int CaseId { get; set; }
        public Nullable<System.DateTime> CaseDate { get; set; }
        public string CreatedBy { get; set; }
        public string Detail { get; set; }
        public string MouldId { get; set; }
        public string ToolingId { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public byte[] MouldDrawing { get; set; }
        public byte[] PartDrawing { get; set; }
        public Nullable<int> Status { get; set; }
        public string ItemId { get; set; }
        public string MouldDrawingId { get; set; }
        public string MouldDrawingExt { get; set; }
        public string PartDrawingExt { get; set; }
        public string BoxType { get; set; }
        public string TrayType { get; set; }
        public Nullable<int> BoxQty { get; set; }
        public Nullable<int> TrayQty { get; set; }
    }
}
