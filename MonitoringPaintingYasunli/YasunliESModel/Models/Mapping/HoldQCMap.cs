using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class HoldQCMap : EntityTypeConfiguration<HoldQC>
    {
        public HoldQCMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HoldQCID, t.BarcodeID });

            // Properties
            this.Property(t => t.HoldQCID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HoldStatusID)
                .HasMaxLength(50);

            this.Property(t => t.ClaimNo)
                .HasMaxLength(50);

            this.Property(t => t.UserHold)
                .HasMaxLength(50);

            this.Property(t => t.UserRelease)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HoldQC", "Shared");
            this.Property(t => t.HoldQCID).HasColumnName("HoldQCID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.HoldStatusID).HasColumnName("HoldStatusID");
            this.Property(t => t.ClaimNo).HasColumnName("ClaimNo");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.UserHold).HasColumnName("UserHold");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
            this.Property(t => t.HoldDate).HasColumnName("HoldDate");
            this.Property(t => t.UserRelease).HasColumnName("UserRelease");
            this.Property(t => t.ReleaseDate).HasColumnName("ReleaseDate");
        }
    }
}
