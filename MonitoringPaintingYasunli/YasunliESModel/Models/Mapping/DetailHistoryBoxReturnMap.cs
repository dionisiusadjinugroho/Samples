using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailHistoryBoxReturnMap : EntityTypeConfiguration<DetailHistoryBoxReturn>
    {
        public DetailHistoryBoxReturnMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailHistoryBoxReturnID);

            // Properties
            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            this.Property(t => t.BoxID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailHistoryBoxReturn", "Inventory");
            this.Property(t => t.DetailHistoryBoxReturnID).HasColumnName("DetailHistoryBoxReturnID");
            this.Property(t => t.HistoryBoxReturnID).HasColumnName("HistoryBoxReturnID");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.ReceivedDate).HasColumnName("ReceivedDate");
        }
    }
}
