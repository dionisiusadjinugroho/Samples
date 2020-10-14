using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PackageChangedMap : EntityTypeConfiguration<PackageChanged>
    {
        public PackageChangedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PackageAkhir)
                .HasMaxLength(50);

            this.Property(t => t.created_by)
                .HasMaxLength(50);

            this.Property(t => t.PackageID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PackageChanged", "Inventory");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PackageAkhir).HasColumnName("PackageAkhir");
            this.Property(t => t.TanggalRubah).HasColumnName("TanggalRubah");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.PackageID).HasColumnName("PackageID");
        }
    }
}
