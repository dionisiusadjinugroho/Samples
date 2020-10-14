using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ECNMap : EntityTypeConfiguration<ECN>
    {
        public ECNMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OldItem, t.NewItem });

            // Properties
            this.Property(t => t.OldItem)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NewItem)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Version)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ECN", "Inventory");
            this.Property(t => t.OldItem).HasColumnName("OldItem");
            this.Property(t => t.NewItem).HasColumnName("NewItem");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.Approval).HasColumnName("Approval");
        }
    }
}
