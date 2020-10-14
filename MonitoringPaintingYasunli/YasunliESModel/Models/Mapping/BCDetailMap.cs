using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BCDetailMap : EntityTypeConfiguration<BCDetail>
    {
        public BCDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.NoSuratJalan)
                .HasMaxLength(50);

            this.Property(t => t.NoPackingList)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BCDetail", "Customs");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.BeratPart).HasColumnName("BeratPart");
            this.Property(t => t.BeratKemasan).HasColumnName("BeratKemasan");
            this.Property(t => t.NoSuratJalan).HasColumnName("NoSuratJalan");
            this.Property(t => t.PricePerUnnit).HasColumnName("PricePerUnnit");
            this.Property(t => t.JumlahSatuan).HasColumnName("JumlahSatuan");
            this.Property(t => t.NoPackingList).HasColumnName("NoPackingList");
            this.Property(t => t.NilaiPabean).HasColumnName("NilaiPabean");
            this.Property(t => t.JumlahBox).HasColumnName("JumlahBox");
        }
    }
}
