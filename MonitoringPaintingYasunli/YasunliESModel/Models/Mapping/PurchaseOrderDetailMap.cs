using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PurchaseOrderDetailMap : EntityTypeConfiguration<PurchaseOrderDetail>
    {
        public PurchaseOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailID);

            // Properties
            this.Property(t => t.PONo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MEMONo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PurchaseOrderDetail", "Inventory");
            this.Property(t => t.DetailID).HasColumnName("DetailID");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.PriceD).HasColumnName("PriceD");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.MEMONo).HasColumnName("MEMONo");

            // Relationships
            this.HasRequired(t => t.Item)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.ItemID);
            this.HasRequired(t => t.Item1)
                .WithMany(t => t.PurchaseOrderDetails1)
                .HasForeignKey(d => d.ItemID);
            this.HasRequired(t => t.PurchaseOrder)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.PONo);

        }
    }
}
