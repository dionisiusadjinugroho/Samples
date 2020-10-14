using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RentalMap : EntityTypeConfiguration<Rental>
    {
        public RentalMap()
        {
            // Primary Key
            this.HasKey(t => t.RentalID);

            // Properties
            this.Property(t => t.RentalID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NamaRental)
                .HasMaxLength(50);

            this.Property(t => t.Telp)
                .HasMaxLength(50);

            this.Property(t => t.Pemilik)
                .HasMaxLength(50);

            this.Property(t => t.NPWP)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Rental", "Shared");
            this.Property(t => t.RentalID).HasColumnName("RentalID");
            this.Property(t => t.NamaRental).HasColumnName("NamaRental");
            this.Property(t => t.AlamatRental).HasColumnName("AlamatRental");
            this.Property(t => t.Telp).HasColumnName("Telp");
            this.Property(t => t.Pemilik).HasColumnName("Pemilik");
            this.Property(t => t.NPWP).HasColumnName("NPWP");
        }
    }
}
