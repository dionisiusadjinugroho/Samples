using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class TrainingModuleMap : EntityTypeConfiguration<TrainingModule>
    {
        public TrainingModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ModuleId);

            // Properties
            this.Property(t => t.ModuleId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModuleName)
                .HasMaxLength(200);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TrainingModule", "Shared");
            this.Property(t => t.ModuleId).HasColumnName("ModuleId");
            this.Property(t => t.ModuleName).HasColumnName("ModuleName");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ValidUntil).HasColumnName("ValidUntil");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
