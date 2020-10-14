using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PickingListDetailMap : EntityTypeConfiguration<PickingListDetail>
    {
        public PickingListDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PickingListDetail", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PickingListHeaderId).HasColumnName("PickingListHeaderId");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
