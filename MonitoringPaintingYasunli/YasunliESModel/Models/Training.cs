using System;

namespace YasunliESModel.Models
{
    public partial class Training
    {
        public string NPK { get; set; }
        public int TrainingId { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<bool> Pass { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentId { get; set; }
    }
}
