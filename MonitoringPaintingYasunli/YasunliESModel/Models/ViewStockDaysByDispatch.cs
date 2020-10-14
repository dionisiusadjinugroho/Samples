using System;

namespace YasunliESModel.Models
{
    public partial class ViewStockDaysByDispatch
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string MainModel { get; set; }
        public string CustomerName { get; set; }
        public Nullable<decimal> CycleTime { get; set; }
        public string MachineGroupID { get; set; }
        public Nullable<decimal> DailyQtyAverage { get; set; }
        public Nullable<int> QtyGudang { get; set; }
        public Nullable<decimal> QtySudahKeluar { get; set; }
        public Nullable<decimal> DaysUsed { get; set; }
        public Nullable<decimal> PercentageSent { get; set; }
        public Nullable<decimal> PercendageMinus { get; set; }
        public Nullable<decimal> DailyCapacity { get; set; }
    }
}
