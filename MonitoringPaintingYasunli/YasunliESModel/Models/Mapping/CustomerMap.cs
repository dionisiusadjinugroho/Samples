using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerID);

            // Properties
            this.Property(t => t.CustomerID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentTermID)
                .HasMaxLength(50);

            this.Property(t => t.DeliveryTermID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerPrefix)
                .HasMaxLength(50);

            this.Property(t => t.NPWP)
                .HasMaxLength(50);

            this.Property(t => t.SKEPKB)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            this.Property(t => t.ICPExpiryDate)
                .HasMaxLength(50);

            this.Property(t => t.NoIzinTPB)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Customer", "Shared");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.PaymentTermID).HasColumnName("PaymentTermID");
            this.Property(t => t.DeliveryTermID).HasColumnName("DeliveryTermID");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.CustomerPrefix).HasColumnName("CustomerPrefix");
            this.Property(t => t.BillingAddress).HasColumnName("BillingAddress");
            this.Property(t => t.ShippingAddress).HasColumnName("ShippingAddress");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.NPWP).HasColumnName("NPWP");
            this.Property(t => t.SKEPKB).HasColumnName("SKEPKB");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.ICPExpiryDate).HasColumnName("ICPExpiryDate");
            this.Property(t => t.masterList).HasColumnName("masterList");
            this.Property(t => t.NoIzinTPB).HasColumnName("NoIzinTPB");
        }
    }
}
