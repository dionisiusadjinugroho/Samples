using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RecyclingLabelMap : EntityTypeConfiguration<RecyclingLabel>
    {
        public RecyclingLabelMap()
        {
            // Primary Key
            this.HasKey(t => t.RecyclingLabelID);

            // Properties
            this.Property(t => t.RecycleId)
                .HasMaxLength(50);

            this.Property(t => t.SackID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RecyclingLabel", "Inventory");
            this.Property(t => t.RecyclingLabelID).HasColumnName("RecyclingLabelID");
            this.Property(t => t.RecycleId).HasColumnName("RecycleId");
            this.Property(t => t.SackID).HasColumnName("SackID");
            this.Property(t => t.Tipe).HasColumnName("Tipe");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
        }
    }
}
