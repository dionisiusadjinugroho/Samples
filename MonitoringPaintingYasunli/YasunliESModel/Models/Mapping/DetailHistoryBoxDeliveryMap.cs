using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailHistoryBoxDeliveryMap : EntityTypeConfiguration<DetailHistoryBoxDelivery>
    {
        public DetailHistoryBoxDeliveryMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailHistoryBoxDeliveryID);

            // Properties
            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            this.Property(t => t.BoxID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailHistoryBoxDelivery", "Inventory");
            this.Property(t => t.DetailHistoryBoxDeliveryID).HasColumnName("DetailHistoryBoxDeliveryID");
            this.Property(t => t.HistoryBoxDeliveryID).HasColumnName("HistoryBoxDeliveryID");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.ScanTime).HasColumnName("ScanTime");
        }
    }
}
