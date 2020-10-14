using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MixingHeaderMap : EntityTypeConfiguration<MixingHeader>
    {
        public MixingHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.MixingId);

            // Properties
            this.Property(t => t.MixingId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaterialType)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.NIK)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MixingHeader", "Inventory");
            this.Property(t => t.MixingId).HasColumnName("MixingId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.MaterialType).HasColumnName("MaterialType");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.NIK).HasColumnName("NIK");
        }
    }
}
