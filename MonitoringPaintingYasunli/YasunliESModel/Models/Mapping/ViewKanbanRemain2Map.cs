using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewKanbanRemain2Map : EntityTypeConfiguration<ViewKanbanRemain2>
    {
        public ViewKanbanRemain2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemName, t.Model, t.Customer });

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.Model)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KanbanId)
                .HasMaxLength(50);

            this.Property(t => t.StrLoc)
                .HasMaxLength(50);

            this.Property(t => t.SupplyArea)
                .HasMaxLength(50);

            this.Property(t => t.Customer)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewKanbanRemain2", "Inventory");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.TransitTime).HasColumnName("TransitTime");
            this.Property(t => t.KanbanId).HasColumnName("KanbanId");
            this.Property(t => t.ETA).HasColumnName("ETA");
            this.Property(t => t.StrLoc).HasColumnName("StrLoc");
            this.Property(t => t.SupplyArea).HasColumnName("SupplyArea");
            this.Property(t => t.Customer).HasColumnName("Customer");
        }
    }
}
