using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MonitoringPaintingMap : EntityTypeConfiguration<MonitoringPainting>
    {
        public MonitoringPaintingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);


            // Table & Column Mappings
            this.ToTable("MonitoringPainting");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.BarcodeIDBox).HasColumnName("BarcodeIDBox");
            this.Property(t => t.ScanCount).HasColumnName("ScanCount");
            this.Property(t => t.Judge).HasColumnName("Judge");
            this.Property(t => t.ScanBy).HasColumnName("ScanBy");
        }
    }
}
