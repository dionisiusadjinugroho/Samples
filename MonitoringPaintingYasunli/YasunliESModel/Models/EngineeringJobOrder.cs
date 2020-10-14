using System;

namespace YasunliESModel.Models
{
    public partial class EngineeringJobOrder
    {
        public int EngineeringJobId { get; set; }
        public Nullable<int> CaseId { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public string Event { get; set; }
        public Nullable<int> TrialNo { get; set; }
        public byte[] Document1 { get; set; }
        public byte[] Document2 { get; set; }
        public byte[] Document3 { get; set; }
        public byte[] Drawing1 { get; set; }
        public byte[] Drawing2 { get; set; }
        public string NextEvent { get; set; }
        public Nullable<System.DateTime> NextEventDate { get; set; }
        public string ReportedBy { get; set; }
        public string Document1Ext { get; set; }
        public string Document2Ext { get; set; }
        public string Document3Ext { get; set; }
        public string Drawing1Ext { get; set; }
        public string Drawing2Ext { get; set; }
        public string Remarks { get; set; }
        public string Document4Ext { get; set; }
        public byte[] Document4 { get; set; }
    }
}
