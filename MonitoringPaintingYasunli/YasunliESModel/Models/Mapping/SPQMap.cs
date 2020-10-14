using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SPQMap : EntityTypeConfiguration<SPQ>
    {
        public SPQMap()
        {
            // Primary Key
            this.HasKey(t => t.SPQID);

            // Properties
            this.Property(t => t.SPQID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.BoxTypeID)
                .HasMaxLength(50);

            this.Property(t => t.TrayType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SPQ", "Inventory");
            this.Property(t => t.SPQID).HasColumnName("SPQID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.BoxTypeID).HasColumnName("BoxTypeID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.BeratBox).HasColumnName("BeratBox");
            this.Property(t => t.VolumeBox).HasColumnName("VolumeBox");
            this.Property(t => t.TrayType).HasColumnName("TrayType");
            this.Property(t => t.TrayQty).HasColumnName("TrayQty");
        }
    }
}
