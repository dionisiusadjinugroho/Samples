using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PaymentTermMap : EntityTypeConfiguration<PaymentTerm>
    {
        public PaymentTermMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentTermID);

            // Properties
            this.Property(t => t.PaymentTermID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PaymentTerms", "Inventory");
            this.Property(t => t.PaymentTermID).HasColumnName("PaymentTermID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Due).HasColumnName("Due");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.PaymentTermType).HasColumnName("PaymentTermType");
        }
    }
}
