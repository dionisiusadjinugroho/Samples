using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class KanbanDetailMap : EntityTypeConfiguration<KanbanDetail>
    {
        public KanbanDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.KanbanDetailId);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.NoKanban)
                .HasMaxLength(50);

            this.Property(t => t.StrLoc)
                .HasMaxLength(50);

            this.Property(t => t.SupplyArea)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("KanbanDetail", "Inventory");
            this.Property(t => t.KanbanDetailId).HasColumnName("KanbanDetailId");
            this.Property(t => t.KanbanId).HasColumnName("KanbanId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.TransitTime).HasColumnName("TransitTime");
            this.Property(t => t.NoKanban).HasColumnName("NoKanban");
            this.Property(t => t.ETA).HasColumnName("ETA");
            this.Property(t => t.ReqDate).HasColumnName("ReqDate");
            this.Property(t => t.StrLoc).HasColumnName("StrLoc");
            this.Property(t => t.SupplyArea).HasColumnName("SupplyArea");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Revisi).HasColumnName("Revisi");
            this.Property(t => t.RevDate).HasColumnName("RevDate");
        }
    }
}
