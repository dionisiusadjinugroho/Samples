using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailReceivingMap : EntityTypeConfiguration<DetailReceiving>
    {
        public DetailReceivingMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailReceivingID);

            // Properties
            this.Property(t => t.DetailReceivingID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ReceivingID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LotNumber)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PurchaseOrderId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.Jenis)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailReceiving", "Inventory");
            this.Property(t => t.DetailReceivingID).HasColumnName("DetailReceivingID");
            this.Property(t => t.ReceivingID).HasColumnName("ReceivingID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.PurchaseOrderId).HasColumnName("PurchaseOrderId");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Jenis).HasColumnName("Jenis");
        }
    }
}
