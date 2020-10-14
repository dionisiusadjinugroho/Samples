using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class OperatorAbsentMap : EntityTypeConfiguration<OperatorAbsent>
    {
        public OperatorAbsentMap()
        {
            // Primary Key
            this.HasKey(t => t.AbsentId);

            // Properties
            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.MachineNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OperatorAbsent", "Shared");
            this.Property(t => t.AbsentId).HasColumnName("AbsentId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.AbsentTime).HasColumnName("AbsentTime");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.MachineNo).HasColumnName("MachineNo");
        }
    }
}
