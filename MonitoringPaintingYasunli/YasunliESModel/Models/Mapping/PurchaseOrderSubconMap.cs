using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PurchaseOrderSubconMap : EntityTypeConfiguration<PurchaseOrderSubcon>
    {
        public PurchaseOrderSubconMap()
        {
            // Primary Key
            this.HasKey(t => t.PONo);

            // Properties
            this.Property(t => t.POSubconNo)
                .IsRequired()
                .HasMaxLength(50);

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

            // Table & Column Mappings
            this.ToTable("PurchaseOrderSubcon", "Inventory");
            this.Property(t => t.POSubconNo).HasColumnName("POSubconNo");
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
        }
    }
}
