using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SuratJalanDeliveryMap : EntityTypeConfiguration<SuratJalanDelivery>
    {
        public SuratJalanDeliveryMap()
        {
            // Primary Key
            this.HasKey(t => t.NoSuratJalan);

            // Properties
            this.Property(t => t.NoSuratJalan)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.created_by)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SuratJalanDelivery", "Inventory");
            this.Property(t => t.NoSuratJalan).HasColumnName("NoSuratJalan");
            this.Property(t => t.TransitID).HasColumnName("TransitID");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.tanggalSJ).HasColumnName("tanggalSJ");
            this.Property(t => t.printed).HasColumnName("printed");
        }
    }
}
