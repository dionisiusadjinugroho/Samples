using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailReturnPartMap : EntityTypeConfiguration<DetailReturnPart>
    {
        public DetailReturnPartMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailReturnPartID);

            // Properties
            this.Property(t => t.ReturnPartID)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.SPQID)
                .HasMaxLength(50);

            this.Property(t => t.ToolingId)
                .HasMaxLength(50);

            this.Property(t => t.Cavity)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailReturnPart", "Inventory");
            this.Property(t => t.DetailReturnPartID).HasColumnName("DetailReturnPartID");
            this.Property(t => t.ReturnPartID).HasColumnName("ReturnPartID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.SPQID).HasColumnName("SPQID");
            this.Property(t => t.SPQQty).HasColumnName("SPQQty");
            this.Property(t => t.ToolingId).HasColumnName("ToolingId");
            this.Property(t => t.Cavity).HasColumnName("Cavity");
        }
    }
}
