using System;

namespace YasunliESModel.Models
{
    public partial class MaterialOutDetail
    {
        public int DetailID { get; set; }
        public string MaterialOutNo { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string Description { get; set; }
        public string LotNumber { get; set; }
        public virtual Item Item { get; set; }
        public virtual Item Item1 { get; set; }
    }
}
