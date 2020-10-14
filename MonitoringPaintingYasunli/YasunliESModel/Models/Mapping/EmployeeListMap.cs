using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class EmployeeListMap : EntityTypeConfiguration<EmployeeList>
    {
        public EmployeeListMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeId);

            // Properties
            this.Property(t => t.EmployeeName)
                .HasMaxLength(500);

            this.Property(t => t.Birthplace)
                .HasMaxLength(200);

            this.Property(t => t.Jabatan)
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.DepartmentId)
                .HasMaxLength(50);

            this.Property(t => t.DivisionId)
                .HasMaxLength(50);

            this.Property(t => t.Refference)
                .HasMaxLength(2000);

            this.Property(t => t.ShiftGroupId)
                .HasMaxLength(50);

            this.Property(t => t.Religion)
                .HasMaxLength(50);

            this.Property(t => t.NoDept)
                .HasMaxLength(50);

            this.Property(t => t.SalaryMethod)
                .HasMaxLength(50);

            this.Property(t => t.npwp)
                .HasMaxLength(50);

            this.Property(t => t.BloodType)
                .HasMaxLength(50);

            this.Property(t => t.Serikat)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmployeeList", "Shared");
            this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            this.Property(t => t.Birthplace).HasColumnName("Birthplace");
            this.Property(t => t.Birthdate).HasColumnName("Birthdate");
            this.Property(t => t.Usia).HasColumnName("Usia");
            this.Property(t => t.MasaKerja).HasColumnName("MasaKerja");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Jabatan).HasColumnName("Jabatan");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.DateIn).HasColumnName("DateIn");
            this.Property(t => t.DateOut).HasColumnName("DateOut");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.DepartmentId).HasColumnName("DepartmentId");
            this.Property(t => t.DivisionId).HasColumnName("DivisionId");
            this.Property(t => t.Refference).HasColumnName("Refference");
            this.Property(t => t.Furlough).HasColumnName("Furlough");
            this.Property(t => t.ShiftGroupId).HasColumnName("ShiftGroupId");
            this.Property(t => t.Religion).HasColumnName("Religion");
            this.Property(t => t.NoDept).HasColumnName("NoDept");
            this.Property(t => t.SalaryMethod).HasColumnName("SalaryMethod");
            this.Property(t => t.npwp).HasColumnName("npwp");
            this.Property(t => t.BloodType).HasColumnName("BloodType");
            this.Property(t => t.Serikat).HasColumnName("Serikat");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
        }
    }
}
