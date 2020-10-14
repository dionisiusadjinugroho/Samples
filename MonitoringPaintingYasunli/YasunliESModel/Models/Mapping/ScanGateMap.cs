using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ScanGateMap : EntityTypeConfiguration<ScanGate>
    {
        public ScanGateMap()
        {
            // Primary Key
            this.HasKey(t => t.GateScanID);

            // Properties
            this.Property(t => t.BarcodeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BarcodeScannerHWID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ScanGate", "Inventory");
            this.Property(t => t.GateScanID).HasColumnName("GateScanID");
            this.Property(t => t.TransitId).HasColumnName("TransitId");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.BarcodeScannerHWID).HasColumnName("BarcodeScannerHWID");
            this.Property(t => t.DateScan).HasColumnName("DateScan");
        }
    }
}
