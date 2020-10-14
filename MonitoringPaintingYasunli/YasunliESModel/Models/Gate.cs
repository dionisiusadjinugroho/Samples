using System;

namespace YasunliESModel.Models
{
    public partial class Gate
    {
        public string ComputerName { get; set; }
        public string Gate1 { get; set; }
        public Nullable<System.DateTime> DateAssigned { get; set; }
        public string AssignedBy { get; set; }
    }
}
