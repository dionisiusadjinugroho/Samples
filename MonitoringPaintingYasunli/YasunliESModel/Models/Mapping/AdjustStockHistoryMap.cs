using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class AdjustStockHistoryMap : EntityTypeConfiguration<AdjustStockHistory>
    {
        public AdjustStockHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.Change_by)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdjustStockHistory", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.QtyBefore).HasColumnName("QtyBefore");
            this.Property(t => t.QtyAfter).HasColumnName("QtyAfter");
            this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
            this.Property(t => t.Change_by).HasColumnName("Change_by");
            this.Property(t => t.Alasan).HasColumnName("Alasan");
        }
    }
}
