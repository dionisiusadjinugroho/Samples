using System;

namespace YasunliESModel.Models
{
    public partial class TrainingHeader
    {
        public int TrainingId { get; set; }
        public string ModuleId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> TrainingDate { get; set; }
        public string CreatedBy { get; set; }
        public string Trainer { get; set; }
    }
}
