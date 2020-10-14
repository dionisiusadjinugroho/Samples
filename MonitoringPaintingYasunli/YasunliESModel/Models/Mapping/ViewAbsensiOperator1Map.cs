using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewAbsensiOperator1Map : EntityTypeConfiguration<ViewAbsensiOperator1>
    {
        public ViewAbsensiOperator1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeId, t.EmployeeName, t.WorkDate, t.JamMasukOperator, t.JamPulangOperator, t.SPPNo, t.Model });

            // Properties
            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmployeeName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.InjectionCode)
                .HasMaxLength(50);

            this.Property(t => t.SPPNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Keterangan)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ViewAbsensiOperator", "Inventory");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            this.Property(t => t.WorkDate).HasColumnName("WorkDate");
            this.Property(t => t.JamMasukOperator).HasColumnName("JamMasukOperator");
            this.Property(t => t.JamPulangOperator).HasColumnName("JamPulangOperator");
            this.Property(t => t.InjectionCode).HasColumnName("InjectionCode");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.SPPMulai).HasColumnName("SPPMulai");
            this.Property(t => t.SPPSelesai).HasColumnName("SPPSelesai");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
        }
    }
}
