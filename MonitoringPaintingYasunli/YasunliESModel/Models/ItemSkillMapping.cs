using System;

namespace YasunliESModel.Models
{
    public partial class ItemSkillMapping
    {
        public string ItemId { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int Id { get; set; }
        public string EndBy { get; set; }
        public Nullable<int> Score { get; set; }
    }
}
