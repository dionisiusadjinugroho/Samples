using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class TrainingHeaderMap : EntityTypeConfiguration<TrainingHeader>
    {
        public TrainingHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.TrainingId);

            // Properties
            this.Property(t => t.ModuleId)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TrainingHeader", "Shared");
            this.Property(t => t.TrainingId).HasColumnName("TrainingId");
            this.Property(t => t.ModuleId).HasColumnName("ModuleId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.TrainingDate).HasColumnName("TrainingDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
        }
    }
}
