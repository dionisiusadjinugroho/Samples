using System;

namespace YasunliESModel.Models
{
    public partial class ViewSkillMappingSPP
    {
        public string SPPNo { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string Cavity { get; set; }
        public string ToolingID { get; set; }
        public string CustomerName { get; set; }
        public string InjectionCode { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string MainModel { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentId { get; set; }
        public Nullable<System.TimeSpan> JamSeharusnyaMasuk { get; set; }
        public Nullable<System.TimeSpan> JamSeharusnyaPulang { get; set; }
        public string Keterangan { get; set; }
        public Nullable<int> Score { get; set; }
    }
}
