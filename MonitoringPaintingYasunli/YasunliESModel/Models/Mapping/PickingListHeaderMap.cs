using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PickingListHeaderMap : EntityTypeConfiguration<PickingListHeader>
    {
        public PickingListHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PickingListHeader", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Cavity).HasColumnName("Cavity");
            this.Property(t => t.Tooling).HasColumnName("Tooling");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
        }
    }
}
