using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class VendorMap : EntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorID);

            // Properties
            this.Property(t => t.VendorID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentTermID)
                .HasMaxLength(50);

            this.Property(t => t.DeliveryTermID)
                .HasMaxLength(50);

            this.Property(t => t.VendorName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .HasMaxLength(200);

            this.Property(t => t.ContactPerson)
                .HasMaxLength(200);

            this.Property(t => t.Phone)
                .HasMaxLength(200);

            this.Property(t => t.NoIzinTPB)
                .HasMaxLength(200);

            this.Property(t => t.NPWP)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vendor", "Shared");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.PaymentTermID).HasColumnName("PaymentTermID");
            this.Property(t => t.DeliveryTermID).HasColumnName("DeliveryTermID");
            this.Property(t => t.VendorName).HasColumnName("VendorName");
            this.Property(t => t.BillingAddress).HasColumnName("BillingAddress");
            this.Property(t => t.ShippingAddress).HasColumnName("ShippingAddress");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.NoIzinTPB).HasColumnName("NoIzinTPB");
            this.Property(t => t.NPWP).HasColumnName("NPWP");
        }
    }
}
