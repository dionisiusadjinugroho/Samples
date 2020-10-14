using System.Collections.Generic;

namespace YasunliESModel.Models
{
    public partial class Currency
    {
        public Currency()
        {
            this.PurchaseOrders = new List<PurchaseOrder>();
        }

        public int Id { get; set; }
        public string KodeCurrency { get; set; }
        public string CreatedBy { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
