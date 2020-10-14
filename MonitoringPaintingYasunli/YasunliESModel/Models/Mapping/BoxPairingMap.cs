using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BoxPairingMap : EntityTypeConfiguration<BoxPairing>
    {
        public BoxPairingMap()
        {
            // Primary Key
            this.HasKey(t => t.BoxPairingID);

            // Properties
            this.Property(t => t.BoxPairingID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BoxTypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BoxPairing", "Inventory");
            this.Property(t => t.BoxPairingID).HasColumnName("BoxPairingID");
            this.Property(t => t.BoxTypeID).HasColumnName("BoxTypeID");
        }
    }
}
