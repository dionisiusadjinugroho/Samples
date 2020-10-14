using System;
using System.Collections.Generic;

namespace YasunliESModel.Models
{
    public partial class MaterialAdjustment
    {
        public MaterialAdjustment()
        {
            this.MaterialAdjustmentDetails = new List<MaterialAdjustmentDetail>();
        }

        public string MaterialAdjustmentNo { get; set; }
        public string PlantID { get; set; }
        public string FromDiv { get; set; }
        public string ToDiv { get; set; }
        public string Shift { get; set; }
        public Nullable<System.DateTime> AdjustmentDate { get; set; }
        public string Description { get; set; }
        public Nullable<int> status { get; set; }
        public string VoidDescription { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string VoidBy { get; set; }
        public Nullable<System.DateTime> VoidDate { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public virtual ICollection<MaterialAdjustmentDetail> MaterialAdjustmentDetails { get; set; }
        public virtual Plant Plant { get; set; }
    }
}