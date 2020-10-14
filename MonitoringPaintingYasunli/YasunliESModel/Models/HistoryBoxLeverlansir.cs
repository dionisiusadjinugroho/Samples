using System;

namespace YasunliESModel.Models
{
    public partial class HistoryBoxLeverlansir
    {
        public int HistoryBoxLeverlansirID { get; set; }
        public string FromPlantID { get; set; }
        public string ToPlantID { get; set; }
        public string DriverID { get; set; }
        public string RentalID { get; set; }
        public string NoPolisi { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Tipe { get; set; }
    }
}
