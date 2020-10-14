using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PurchaseOrderSubconDetailMap : EntityTypeConfiguration<PurchaseOrderSubconDetail>
    {
        public PurchaseOrderSubconDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailID);

            // Properties
            this.Property(t => t.POSubconNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PurchaseOrderSubconDetail", "Inventory");
            this.Property(t => t.DetailID).HasColumnName("DetailID");
            this.Property(t => t.POSubconNo).HasColumnName("POSubconNo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.PriceD).HasColumnName("PriceD");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
        }
    }
}
