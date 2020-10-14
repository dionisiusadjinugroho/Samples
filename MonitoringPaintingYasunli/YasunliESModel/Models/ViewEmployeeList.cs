using System;

namespace YasunliESModel.Models
{
    public partial class ViewEmployeeList
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Birthplace { get; set; }
        public System.DateTime Birthdate { get; set; }
        public Nullable<decimal> Usia { get; set; }
        public Nullable<decimal> MasaKerja { get; set; }
        public string Address { get; set; }
        public string Jabatan { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateIn { get; set; }
        public Nullable<System.DateTime> DateOut { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public string DepartmentId { get; set; }
        public string DivisionId { get; set; }
        public string Refference { get; set; }
        public int Furlough { get; set; }
        public string Notes { get; set; }
        public string ShiftGroupId { get; set; }
        public string Religion { get; set; }
        public string NoDept { get; set; }
        public string SalaryMethod { get; set; }
        public string npwp { get; set; }
        public string BloodType { get; set; }
        public string Serikat { get; set; }
    }
}
