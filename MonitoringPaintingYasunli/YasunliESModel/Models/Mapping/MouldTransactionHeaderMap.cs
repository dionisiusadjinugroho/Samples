using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldTransactionHeaderMap : EntityTypeConfiguration<MouldTransactionHeader>
    {
        public MouldTransactionHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.MouldTransactionId);

            // Properties
            this.Property(t => t.MouldTransactionId)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.VendorID)
                .HasMaxLength(50);

            this.Property(t => t.NoSuratJalan)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MouldTransactionHeader", "Inventory");
            this.Property(t => t.MouldTransactionId).HasColumnName("MouldTransactionId");
            this.Property(t => t.NomorKontrak).HasColumnName("NomorKontrak");
            this.Property(t => t.NomorAju).HasColumnName("NomorAju");
            this.Property(t => t.NomorDokumen).HasColumnName("NomorDokumen");
            this.Property(t => t.TanggalTransaksi).HasColumnName("TanggalTransaksi");
            this.Property(t => t.TanggalDokumen).HasColumnName("TanggalDokumen");
            this.Property(t => t.RegMasuk).HasColumnName("RegMasuk");
            this.Property(t => t.KB).HasColumnName("KB");
            this.Property(t => t.Jenis).HasColumnName("Jenis");
            this.Property(t => t.JenisBC).HasColumnName("JenisBC");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.TanggalKontrak).HasColumnName("TanggalKontrak");
            this.Property(t => t.NoSuratJalan).HasColumnName("NoSuratJalan");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
        }
    }
}
