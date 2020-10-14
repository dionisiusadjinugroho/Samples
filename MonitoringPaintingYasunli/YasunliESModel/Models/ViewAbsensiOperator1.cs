using System;

namespace YasunliESModel.Models
{
    public partial class ViewAbsensiOperator1
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public System.DateTime WorkDate { get; set; }
        public System.TimeSpan JamMasukOperator { get; set; }
        public System.TimeSpan JamPulangOperator { get; set; }
        public string InjectionCode { get; set; }
        public string SPPNo { get; set; }
        public Nullable<System.DateTime> SPPMulai { get; set; }
        public Nullable<System.DateTime> SPPSelesai { get; set; }
        public string ItemCode { get; set; }
        public string Model { get; set; }
        public string Keterangan { get; set; }
    }
}
