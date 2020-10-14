using System;

namespace AndonMVC.Models
{
    public partial class vspplist
    {
        public Nullable<int> sppid { get; set; }
        public string SPP_No { get; set; }
        public string Customer { get; set; }
        public string Mold_ID { get; set; }
        public Nullable<int> Target { get; set; }
        public Nullable<int> CT { get; set; }
        public Nullable<int> DT { get; set; }
        public string moldid { get; set; }
        public string mold_tooling { get; set; }
        public string mold_material { get; set; }
        public long J_Part { get; set; }
    }
}
