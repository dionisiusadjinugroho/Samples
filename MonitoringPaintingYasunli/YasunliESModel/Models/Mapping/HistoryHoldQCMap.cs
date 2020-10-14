using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class HistoryHoldQCMap : EntityTypeConfiguration<HistoryHoldQC>
    {
        public HistoryHoldQCMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryHoldQCID);

            // Properties
            this.Property(t => t.HoldQCID)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.Kategori)
                .HasMaxLength(50);

            this.Property(t => t.admID)
                .HasMaxLength(50);

            this.Property(t => t.plannerID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HistoryHoldQC", "Shared");
            this.Property(t => t.HistoryHoldQCID).HasColumnName("HistoryHoldQCID");
            this.Property(t => t.HoldQCID).HasColumnName("HoldQCID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.Kategori).HasColumnName("Kategori");
            this.Property(t => t.created_at).HasColumnName("created_at");
            this.Property(t => t.admID).HasColumnName("admID");
            this.Property(t => t.plannerID).HasColumnName("plannerID");
            this.Property(t => t.hold_date).HasColumnName("hold_date");
            this.Property(t => t.release_date).HasColumnName("release_date");
        }
    }
}
