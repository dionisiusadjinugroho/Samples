using System;

namespace YasunliESModel.Models
{
    public partial class OperatorAbsent
    {
        public System.Guid AbsentId { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<System.DateTime> AbsentTime { get; set; }
        public string Type { get; set; }
        public string MachineNo { get; set; }
    }
}
