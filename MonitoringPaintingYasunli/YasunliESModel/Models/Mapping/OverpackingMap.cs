using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class OverpackingMap : EntityTypeConfiguration<Overpacking>
    {
        public OverpackingMap()
        {
            // Primary Key
            this.HasKey(t => t.IDOverpacking);

            // Properties
            this.Property(t => t.IDOverpacking)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.BoxType)
                .HasMaxLength(50);

            this.Property(t => t.created_by)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Overpacking", "Inventory");
            this.Property(t => t.IDOverpacking).HasColumnName("IDOverpacking");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.BoxType).HasColumnName("BoxType");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.created_by).HasColumnName("created_by");
        }
    }
}
