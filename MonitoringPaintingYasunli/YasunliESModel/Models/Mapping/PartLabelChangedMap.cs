using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PartLabelChangedMap : EntityTypeConfiguration<PartLabelChanged>
    {
        public PartLabelChangedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PackageID)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PartLabelChanged", "Inventory");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabelID).HasColumnName("LabelID");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.created_at).HasColumnName("created_at");
            this.Property(t => t.PackageID).HasColumnName("PackageID");
            this.Property(t => t.Location).HasColumnName("Location");
        }
    }
}
