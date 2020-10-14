using System;

namespace YasunliESModel.Models
{
    public partial class MaterialReturnDetail1
    {
        public int DetailID { get; set; }
        public string ReturnNo { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string Description { get; set; }
        public string LotNumber { get; set; }
        public virtual Item Item { get; set; }
        public virtual Item Item1 { get; set; }
        public virtual MaterialReturn1 MaterialReturn1 { get; set; }
    }
}
