using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PurchaseOrderMap : EntityTypeConfiguration<PurchaseOrder>
    {
        public PurchaseOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.PONo);

            // Properties
            this.Property(t => t.PONo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Attn)
                .HasMaxLength(100);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.VoidBy)
                .HasMaxLength(50);

            this.Property(t => t.ClosedBy)
                .HasMaxLength(50);

            this.Property(t => t.PoType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PurchaseOrder", "Inventory");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.PODate).HasColumnName("PODate");
            this.Property(t => t.Attn).HasColumnName("Attn");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TaxType).HasColumnName("TaxType");
            this.Property(t => t.VoidDescription).HasColumnName("VoidDescription");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.VoidBy).HasColumnName("VoidBy");
            this.Property(t => t.VoidDate).HasColumnName("VoidDate");
            this.Property(t => t.ClosedBy).HasColumnName("ClosedBy");
            this.Property(t => t.ClosedDate).HasColumnName("ClosedDate");
            this.Property(t => t.PrintCount).HasColumnName("PrintCount");
            this.Property(t => t.PoType).HasColumnName("PoType");

            // Relationships
            this.HasOptional(t => t.Currency)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(d => d.CurrencyID);
            this.HasRequired(t => t.Plant)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(d => d.PlantID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
