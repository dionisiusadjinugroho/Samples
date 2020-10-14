using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PackageDetailMap : EntityTypeConfiguration<PackageDetail>
    {
        public PackageDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.PackageDetailID);

            // Properties
            this.Property(t => t.PackageID)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.Receive_By)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PackageDetail", "Inventory");
            this.Property(t => t.PackageDetailID).HasColumnName("PackageDetailID");
            this.Property(t => t.PackageID).HasColumnName("PackageID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Receive_By).HasColumnName("Receive_By");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
        }
    }
}
