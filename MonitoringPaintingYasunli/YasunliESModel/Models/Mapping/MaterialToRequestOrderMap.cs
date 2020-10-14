using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MaterialToRequestOrderMap : EntityTypeConfiguration<MaterialToRequestOrder>
    {
        public MaterialToRequestOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialToMixingId);

            // Properties
            this.Property(t => t.RequestOrderId)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialToRequestOrder", "Inventory");
            this.Property(t => t.MaterialToMixingId).HasColumnName("MaterialToMixingId");
            this.Property(t => t.RequestOrderId).HasColumnName("RequestOrderId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
