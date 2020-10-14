using System;

namespace YasunliESModel.Models
{
    public partial class TrainingModule
    {
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ValidUntil { get; set; }
        public string Description { get; set; }
    }
}
