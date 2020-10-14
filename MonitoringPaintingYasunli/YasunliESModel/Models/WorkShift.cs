namespace YasunliESModel.Models
{
    public partial class WorkShift
    {
        public string EmployeeId { get; set; }
        public System.DateTime WorkDate { get; set; }
        public System.TimeSpan WorkHourStart { get; set; }
        public System.TimeSpan WorkHourEnd { get; set; }
        public string MachineNo { get; set; }
    }
}
