using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PackageChangedDetailMap : EntityTypeConfiguration<PackageChangedDetail>
    {
        public PackageChangedDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BarcodeId)
                .HasMaxLength(50);

            this.Property(t => t.PackageAwal)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PackageChangedDetail", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PackageChanged_Id).HasColumnName("PackageChanged_Id");
            this.Property(t => t.BarcodeId).HasColumnName("BarcodeId");
            this.Property(t => t.PackageAwal).HasColumnName("PackageAwal");
        }
    }
}
