using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailHistoryBoxLeverlansirMap : EntityTypeConfiguration<DetailHistoryBoxLeverlansir>
    {
        public DetailHistoryBoxLeverlansirMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailHistoryBoxLeverlansirID);

            // Properties
            this.Property(t => t.BoxID)
                .HasMaxLength(50);

            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailHistoryBoxLeverlansir", "Inventory");
            this.Property(t => t.DetailHistoryBoxLeverlansirID).HasColumnName("DetailHistoryBoxLeverlansirID");
            this.Property(t => t.HistoryBoxLeverlansirID).HasColumnName("HistoryBoxLeverlansirID");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.ReceivedDate).HasColumnName("ReceivedDate");
        }
    }
}
