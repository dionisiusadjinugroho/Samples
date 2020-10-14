using System.Collections.Generic;

namespace YasunliESModel.Models
{
    public partial class Plant
    {
        public Plant()
        {
            this.MaterialAdjustments = new List<MaterialAdjustment>();
            this.MaterialOuts = new List<MaterialOut>();
            this.MaterialReceivings = new List<MaterialReceiving>();
            this.MaterialReturn1 = new List<MaterialReturn1>();
            this.PurchaseOrders = new List<PurchaseOrder>();
        }

        public string PlantID { get; set; }
        public string PlantName { get; set; }
        public string Address { get; set; }
        public string SKEPKB { get; set; }
        public virtual ICollection<MaterialAdjustment> MaterialAdjustments { get; set; }
        public virtual ICollection<MaterialOut> MaterialOuts { get; set; }
        public virtual ICollection<MaterialReceiving> MaterialReceivings { get; set; }
        public virtual ICollection<MaterialReturn1> MaterialReturn1 { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
