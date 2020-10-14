using System;

namespace YasunliESModel.Models
{
    public partial class PartLabelChanged
    {
        public int ID { get; set; }
        public Nullable<int> LabelID { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string PackageID { get; set; }
        public string Location { get; set; }
    }
}
