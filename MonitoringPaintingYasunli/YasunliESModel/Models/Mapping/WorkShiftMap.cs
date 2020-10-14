using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class WorkShiftMap : EntityTypeConfiguration<WorkShift>
    {
        public WorkShiftMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeId, t.WorkDate, t.WorkHourStart, t.MachineNo });

            // Properties
            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MachineNo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkShift", "Shared");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.WorkDate).HasColumnName("WorkDate");
            this.Property(t => t.WorkHourStart).HasColumnName("WorkHourStart");
            this.Property(t => t.WorkHourEnd).HasColumnName("WorkHourEnd");
            this.Property(t => t.MachineNo).HasColumnName("MachineNo");
        }
    }
}
