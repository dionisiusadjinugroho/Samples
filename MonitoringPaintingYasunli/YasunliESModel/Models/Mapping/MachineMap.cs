using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MachineMap : EntityTypeConfiguration<Machine>
    {
        public MachineMap()
        {
            // Primary Key
            this.HasKey(t => t.MachineID);

            // Properties
            this.Property(t => t.MachineID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.InjectionCode)
                .HasMaxLength(50);

            this.Property(t => t.ScrewCode)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ScrewDiameter)
                .HasMaxLength(50);

            this.Property(t => t.InjectionCapacityCalculated)
                .HasMaxLength(50);

            this.Property(t => t.InjectionCapacityPS)
                .HasMaxLength(50);

            this.Property(t => t.InjectionCapcityPE)
                .HasMaxLength(50);

            this.Property(t => t.InjectionPressure)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.InjectionRate)
                .HasMaxLength(50);

            this.Property(t => t.PlastizisingCapacity)
                .HasMaxLength(50);

            this.Property(t => t.MaximumScrewRotationSpeed)
                .HasMaxLength(50);

            this.Property(t => t.ClampingForce)
                .HasMaxLength(50);

            this.Property(t => t.MoldOpeningForce)
                .HasMaxLength(50);

            this.Property(t => t.DistanceBetweenTieRods)
                .HasMaxLength(50);

            this.Property(t => t.PlateDimension)
                .HasMaxLength(50);

            this.Property(t => t.ClampingStroke)
                .HasMaxLength(50);

            this.Property(t => t.MaxDistanceOpen)
                .HasMaxLength(50);

            this.Property(t => t.MoldClosingSpeed)
                .HasMaxLength(50);

            this.Property(t => t.EjectionStroke)
                .HasMaxLength(50);

            this.Property(t => t.UtilizedOilQuantity)
                .HasMaxLength(50);

            this.Property(t => t.ElectricalRequerimentPumpMotors)
                .HasMaxLength(50);

            this.Property(t => t.HeaterCapacity)
                .HasMaxLength(50);

            this.Property(t => t.MachineDimension)
                .HasMaxLength(50);

            this.Property(t => t.MachineWeight)
                .HasMaxLength(50);

            this.Property(t => t.MoldClosingSpeedLow)
                .HasMaxLength(50);

            this.Property(t => t.MoldOpeningSpeedLow)
                .HasMaxLength(50);

            this.Property(t => t.MinimumMoldThickness)
                .HasMaxLength(50);

            this.Property(t => t.MoldOpeningSpeed)
                .HasMaxLength(50);

            this.Property(t => t.EjectionForce)
                .HasMaxLength(50);

            this.Property(t => t.ShootMaterial)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Machine", "Inventory");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.InjectionCode).HasColumnName("InjectionCode");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ScrewCode).HasColumnName("ScrewCode");
            this.Property(t => t.ScrewDiameter).HasColumnName("ScrewDiameter");
            this.Property(t => t.InjectionCapacityCalculated).HasColumnName("InjectionCapacityCalculated");
            this.Property(t => t.InjectionCapacityPS).HasColumnName("InjectionCapacityPS");
            this.Property(t => t.InjectionCapcityPE).HasColumnName("InjectionCapcityPE");
            this.Property(t => t.InjectionPressure).HasColumnName("InjectionPressure");
            this.Property(t => t.InjectionRate).HasColumnName("InjectionRate");
            this.Property(t => t.PlastizisingCapacity).HasColumnName("PlastizisingCapacity");
            this.Property(t => t.MaximumScrewRotationSpeed).HasColumnName("MaximumScrewRotationSpeed");
            this.Property(t => t.ClampingForce).HasColumnName("ClampingForce");
            this.Property(t => t.MoldOpeningForce).HasColumnName("MoldOpeningForce");
            this.Property(t => t.DistanceBetweenTieRods).HasColumnName("DistanceBetweenTieRods");
            this.Property(t => t.PlateDimension).HasColumnName("PlateDimension");
            this.Property(t => t.ClampingStroke).HasColumnName("ClampingStroke");
            this.Property(t => t.MaxDistanceOpen).HasColumnName("MaxDistanceOpen");
            this.Property(t => t.MoldClosingSpeed).HasColumnName("MoldClosingSpeed");
            this.Property(t => t.EjectionStroke).HasColumnName("EjectionStroke");
            this.Property(t => t.UtilizedOilQuantity).HasColumnName("UtilizedOilQuantity");
            this.Property(t => t.ElectricalRequerimentPumpMotors).HasColumnName("ElectricalRequerimentPumpMotors");
            this.Property(t => t.HeaterCapacity).HasColumnName("HeaterCapacity");
            this.Property(t => t.MachineDimension).HasColumnName("MachineDimension");
            this.Property(t => t.MachineWeight).HasColumnName("MachineWeight");
            this.Property(t => t.MoldClosingSpeedLow).HasColumnName("MoldClosingSpeedLow");
            this.Property(t => t.MoldOpeningSpeedLow).HasColumnName("MoldOpeningSpeedLow");
            this.Property(t => t.MinimumMoldThickness).HasColumnName("MinimumMoldThickness");
            this.Property(t => t.MoldOpeningSpeed).HasColumnName("MoldOpeningSpeed");
            this.Property(t => t.EjectionForce).HasColumnName("EjectionForce");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ShootWeight).HasColumnName("ShootWeight");
            this.Property(t => t.ShootMaterial).HasColumnName("ShootMaterial");
        }
    }
}
