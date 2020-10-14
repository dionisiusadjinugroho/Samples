using System;

namespace YasunliESModel.Models
{
    public partial class Sampling
    {
        public string BarcodeID { get; set; }
        public string NIK { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public string Judge { get; set; }
        public string Detail { get; set; }
        public string NoDokumen { get; set; }
        public Nullable<int> JobId { get; set; }
        public string NPKOperator { get; set; }
        public string NPKOperator2 { get; set; }
        public string NPKOperator3 { get; set; }
        public string NPKOperator4 { get; set; }
        public Nullable<int> LotSize { get; set; }
        public Nullable<int> SamplingSize { get; set; }
        public Nullable<int> NGQty { get; set; }
        public Nullable<System.DateTime> StartSampling { get; set; }
        public Nullable<System.DateTime> EndSampling { get; set; }
        public string Criteria { get; set; }
    }
}
