using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class TrainingMap : EntityTypeConfiguration<Training>
    {
        public TrainingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NPK, t.TrainingId });

            // Properties
            this.Property(t => t.NPK)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TrainingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeName)
                .HasMaxLength(200);

            this.Property(t => t.DepartmentId)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Training", "Shared");
            this.Property(t => t.NPK).HasColumnName("NPK");
            this.Property(t => t.TrainingId).HasColumnName("TrainingId");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Pass).HasColumnName("Pass");
            this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            this.Property(t => t.DepartmentId).HasColumnName("DepartmentId");
        }
    }
}
