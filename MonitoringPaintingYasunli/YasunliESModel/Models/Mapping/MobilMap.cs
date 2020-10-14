using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MobilMap : EntityTypeConfiguration<Mobil>
    {
        public MobilMap()
        {
            // Primary Key
            this.HasKey(t => t.NoPolisi);

            // Properties
            this.Property(t => t.NoPolisi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RentalID)
                .HasMaxLength(50);

            this.Property(t => t.TipeMobil)
                .HasMaxLength(50);

            this.Property(t => t.NoSTNK)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Mobil", "Shared");
            this.Property(t => t.NoPolisi).HasColumnName("NoPolisi");
            this.Property(t => t.RentalID).HasColumnName("RentalID");
            this.Property(t => t.TipeMobil).HasColumnName("TipeMobil");
            this.Property(t => t.NoSTNK).HasColumnName("NoSTNK");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
        }
    }
}
