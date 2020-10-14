using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DriverMap : EntityTypeConfiguration<Driver>
    {
        public DriverMap()
        {
            // Primary Key
            this.HasKey(t => t.DriverID);

            // Properties
            this.Property(t => t.DriverID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RentalID)
                .HasMaxLength(50);

            this.Property(t => t.NamaDriver)
                .HasMaxLength(50);

            this.Property(t => t.TempatLahir)
                .HasMaxLength(50);

            this.Property(t => t.NoKTP)
                .HasMaxLength(50);

            this.Property(t => t.NoSIM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Driver", "Shared");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.RentalID).HasColumnName("RentalID");
            this.Property(t => t.NamaDriver).HasColumnName("NamaDriver");
            this.Property(t => t.AlamatDriver).HasColumnName("AlamatDriver");
            this.Property(t => t.TempatLahir).HasColumnName("TempatLahir");
            this.Property(t => t.TanggalLahir).HasColumnName("TanggalLahir");
            this.Property(t => t.NoKTP).HasColumnName("NoKTP");
            this.Property(t => t.NoSIM).HasColumnName("NoSIM");
            this.Property(t => t.ValidUntil).HasColumnName("ValidUntil");
            this.Property(t => t.Finger).HasColumnName("Finger");
        }
    }
}
