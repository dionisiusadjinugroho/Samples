using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LeverlansirMap : EntityTypeConfiguration<Leverlansir>
    {
        public LeverlansirMap()
        {
            // Primary Key
            this.HasKey(t => t.NoSuratJalan);

            // Properties
            this.Property(t => t.NoSuratJalan)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sender)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Leverlansir", "Shared");
            this.Property(t => t.NoSuratJalan).HasColumnName("NoSuratJalan");
            this.Property(t => t.Json).HasColumnName("Json");
            this.Property(t => t.TimeReceived).HasColumnName("TimeReceived");
            this.Property(t => t.Sender).HasColumnName("Sender");
        }
    }
}
