using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewKanbanRemainMap : EntityTypeConfiguration<ViewKanbanRemain>
    {
        public ViewKanbanRemainMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemName, t.Model, t.QtyGudang, t.Customer });

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.Model)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.QtyGudang)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KanbanId)
                .HasMaxLength(50);

            this.Property(t => t.StrLoc)
                .HasMaxLength(50);

            this.Property(t => t.SupplyArea)
                .HasMaxLength(50);

            this.Property(t => t.Customer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewKanbanRemain", "Inventory");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.QtyGudang).HasColumnName("QtyGudang");
            this.Property(t => t.TransitTime).HasColumnName("TransitTime");
            this.Property(t => t.ETD).HasColumnName("ETD");
            this.Property(t => t.KanbanId).HasColumnName("KanbanId");
            this.Property(t => t.ETA).HasColumnName("ETA");
            this.Property(t => t.StrLoc).HasColumnName("StrLoc");
            this.Property(t => t.SupplyArea).HasColumnName("SupplyArea");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.ReqDate).HasColumnName("ReqDate");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
