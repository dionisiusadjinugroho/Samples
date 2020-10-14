using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailAssemblingMap : EntityTypeConfiguration<DetailAssembling>
    {
        public DetailAssemblingMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailAssemblingId);

            // Properties
            this.Property(t => t.AssemblingId)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailAssembling", "Inventory");
            this.Property(t => t.DetailAssemblingId).HasColumnName("DetailAssemblingId");
            this.Property(t => t.AssemblingId).HasColumnName("AssemblingId");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.scan_date).HasColumnName("scan_date");
        }
    }
}
