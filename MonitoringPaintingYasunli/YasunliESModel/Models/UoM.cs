using System;

namespace YasunliESModel.Models
{
    public partial class UoM
    {
        public string UoMID { get; set; }
        public string Description { get; set; }
        public string BaseUnit { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
