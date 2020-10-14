using System;

namespace YasunliESModel.Models
{
    public partial class Assembling
    {
        public string AssemblingId { get; set; }
        public string ItemID { get; set; }
        public string BoxType { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string created_by { get; set; }
    }
}
