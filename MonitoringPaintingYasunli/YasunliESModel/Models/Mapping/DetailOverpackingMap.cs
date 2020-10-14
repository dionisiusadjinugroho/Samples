using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailOverpackingMap : EntityTypeConfiguration<DetailOverpacking>
    {
        public DetailOverpackingMap()
        {
            // Primary Key
            this.HasKey(t => t.IDDetailOverpacking);

            // Properties
            this.Property(t => t.IDOverpacking)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailOverpacking", "Inventory");
            this.Property(t => t.IDDetailOverpacking).HasColumnName("IDDetailOverpacking");
            this.Property(t => t.IDOverpacking).HasColumnName("IDOverpacking");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.scan_date).HasColumnName("scan_date");
        }
    }
}
