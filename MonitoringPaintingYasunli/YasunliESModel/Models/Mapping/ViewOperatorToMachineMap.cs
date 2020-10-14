using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewOperatorToMachineMap : EntityTypeConfiguration<ViewOperatorToMachine>
    {
        public ViewOperatorToMachineMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SPPNo, t.EmployeeId, t.EmployeeName });

            // Properties
            this.Property(t => t.SPPNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InjectionCode)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmployeeName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.DepartmentId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewOperatorToMachine", "Quality");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.InjectionCode).HasColumnName("InjectionCode");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            this.Property(t => t.DepartmentId).HasColumnName("DepartmentId");
            this.Property(t => t.JumlahTemuanLQC).HasColumnName("JumlahTemuanLQC");
        }
    }
}
