using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BarcodeScannerMap : EntityTypeConfiguration<BarcodeScanner>
    {
        public BarcodeScannerMap()
        {
            // Primary Key
            this.HasKey(t => t.BarcodeScannerId);

            // Properties
            this.Property(t => t.BarcodeScannerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BarcodeScannerSeries)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BarcodeScannerFA)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BarcodeScannerHWID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BarcodeScanner", "Inventory");
            this.Property(t => t.BarcodeScannerId).HasColumnName("BarcodeScannerId");
            this.Property(t => t.BarcodeScannerName).HasColumnName("BarcodeScannerName");
            this.Property(t => t.BarcodeScannerSeries).HasColumnName("BarcodeScannerSeries");
            this.Property(t => t.BarcodeScannerFA).HasColumnName("BarcodeScannerFA");
            this.Property(t => t.BarcodeScannerHWID).HasColumnName("BarcodeScannerHWID");
        }
    }
}
