using System;

namespace YasunliESModel.Models
{
    public partial class Machine
    {
        public string MachineID { get; set; }
        public string PlantID { get; set; }
        public string InjectionCode { get; set; }
        public Nullable<bool> Status { get; set; }
        public string ScrewCode { get; set; }
        public string ScrewDiameter { get; set; }
        public string InjectionCapacityCalculated { get; set; }
        public string InjectionCapacityPS { get; set; }
        public string InjectionCapcityPE { get; set; }
        public string InjectionPressure { get; set; }
        public string InjectionRate { get; set; }
        public string PlastizisingCapacity { get; set; }
        public string MaximumScrewRotationSpeed { get; set; }
        public string ClampingForce { get; set; }
        public string MoldOpeningForce { get; set; }
        public string DistanceBetweenTieRods { get; set; }
        public string PlateDimension { get; set; }
        public string ClampingStroke { get; set; }
        public string MaxDistanceOpen { get; set; }
        public string MoldClosingSpeed { get; set; }
        public string EjectionStroke { get; set; }
        public string UtilizedOilQuantity { get; set; }
        public string ElectricalRequerimentPumpMotors { get; set; }
        public string HeaterCapacity { get; set; }
        public string MachineDimension { get; set; }
        public string MachineWeight { get; set; }
        public string MoldClosingSpeedLow { get; set; }
        public string MoldOpeningSpeedLow { get; set; }
        public string MinimumMoldThickness { get; set; }
        public string MoldOpeningSpeed { get; set; }
        public string EjectionForce { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> ShootWeight { get; set; }
        public string ShootMaterial { get; set; }
    }
}
