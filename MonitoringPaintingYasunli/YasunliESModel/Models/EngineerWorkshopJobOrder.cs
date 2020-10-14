using System;

namespace YasunliESModel.Models
{
    public partial class EngineerWorkshopJobOrder
    {
        public int JobOrderID { get; set; }
        public string MouldCode { get; set; }
        public string MouldName { get; set; }
        public string Tooling { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> Approved { get; set; }
        public Nullable<bool> Finished { get; set; }
        public byte[] Picture { get; set; }
        public string DetailEng { get; set; }
        public string DetailWorkshop { get; set; }
        public string MouldID { get; set; }
        public string NPKEng { get; set; }
        public string NPKWorkshop { get; set; }
        public string NPKDone { get; set; }
        public string NPKFinalize { get; set; }
        public string Judgement { get; set; }
        public string DetailJudgement { get; set; }
        public Nullable<bool> Overhaul { get; set; }
        public string ItemIDOld { get; set; }
        public string ItemIDNew { get; set; }
        public string MouldDefectCategory { get; set; }
    }
}
