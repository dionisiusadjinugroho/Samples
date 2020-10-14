using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class QueueGateMap : EntityTypeConfiguration<QueueGate>
    {
        public QueueGateMap()
        {
            // Primary Key
            this.HasKey(t => t.QueueId);

            // Properties
            this.Property(t => t.BarcodeId)
                .HasMaxLength(50);

            this.Property(t => t.QCScan)
                .HasMaxLength(50);

            this.Property(t => t.WHScan)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QueueGate", "Quality");
            this.Property(t => t.QueueId).HasColumnName("QueueId");
            this.Property(t => t.BarcodeId).HasColumnName("BarcodeId");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.SaveDate).HasColumnName("SaveDate");
            this.Property(t => t.QCScan).HasColumnName("QCScan");
            this.Property(t => t.WHScan).HasColumnName("WHScan");
            this.Property(t => t.QCScanDate).HasColumnName("QCScanDate");
            this.Property(t => t.WHScanDate).HasColumnName("WHScanDate");
        }
    }
}
