using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MixingToRequestOrderMap : EntityTypeConfiguration<MixingToRequestOrder>
    {
        public MixingToRequestOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.MixingToRequestOrderID);

            // Properties
            this.Property(t => t.RequestOrderID)
                .HasMaxLength(50);

            this.Property(t => t.SackID)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.MixingID)
                .HasMaxLength(50);

            this.Property(t => t.NIK)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MixingToRequestOrder", "Inventory");
            this.Property(t => t.MixingToRequestOrderID).HasColumnName("MixingToRequestOrderID");
            this.Property(t => t.RequestOrderID).HasColumnName("RequestOrderID");
            this.Property(t => t.SackID).HasColumnName("SackID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.ScanTime).HasColumnName("ScanTime");
            this.Property(t => t.MixingID).HasColumnName("MixingID");
            this.Property(t => t.NIK).HasColumnName("NIK");
        }
    }
}
