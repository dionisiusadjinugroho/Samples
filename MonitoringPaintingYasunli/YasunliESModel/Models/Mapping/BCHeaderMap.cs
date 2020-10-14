using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BCHeaderMap : EntityTypeConfiguration<BCHeader>
    {
        public BCHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.NoPackingList);

            // Properties
            this.Property(t => t.NoPackingList)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NoTglPendaftaran)
                .HasMaxLength(50);

            this.Property(t => t.NamaPerusahaan)
                .HasMaxLength(50);

            this.Property(t => t.NoKontrak)
                .HasMaxLength(50);

            this.Property(t => t.EXBC40)
                .HasMaxLength(50);

            this.Property(t => t.JenisPengankut)
                .HasMaxLength(50);

            this.Property(t => t.NomorPolisi)
                .HasMaxLength(50);

            this.Property(t => t.JenisKemasan)
                .HasMaxLength(10);

            this.Property(t => t.JenisTrans)
                .HasMaxLength(50);

            this.Property(t => t.NoInvoice)
                .HasMaxLength(50);

            this.Property(t => t.FinalDestination)
                .HasMaxLength(50);

            this.Property(t => t.NomorPengajuan)
                .HasMaxLength(50);

            this.Property(t => t.NPWPCustomer)
                .HasMaxLength(50);

            this.Property(t => t.NamaCustomer)
                .HasMaxLength(50);

            this.Property(t => t.NomorIzinPTBCustomer)
                .HasMaxLength(50);

            this.Property(t => t.PosTarifHS)
                .HasMaxLength(50);

            this.Property(t => t.JenisValutaAsing)
                .HasMaxLength(10);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.NPWPSender)
                .HasMaxLength(50);

            this.Property(t => t.NamaSender)
                .HasMaxLength(50);

            this.Property(t => t.KantorAsal)
                .HasMaxLength(50);

            this.Property(t => t.KantorTujuan)
                .HasMaxLength(50);

            this.Property(t => t.JenisTPBAsal)
                .HasMaxLength(50);

            this.Property(t => t.JenisTPBTujuan)
                .HasMaxLength(50);

            this.Property(t => t.NoSegel)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BCHeader", "Customs");
            this.Property(t => t.NoPackingList).HasColumnName("NoPackingList");
            this.Property(t => t.NoTglPendaftaran).HasColumnName("NoTglPendaftaran");
            this.Property(t => t.Tanggal).HasColumnName("Tanggal");
            this.Property(t => t.NamaPerusahaan).HasColumnName("NamaPerusahaan");
            this.Property(t => t.Alamat).HasColumnName("Alamat");
            this.Property(t => t.NoKontrak).HasColumnName("NoKontrak");
            this.Property(t => t.EXBC40).HasColumnName("EXBC40");
            this.Property(t => t.TanggalEXBC).HasColumnName("TanggalEXBC");
            this.Property(t => t.JenisPengankut).HasColumnName("JenisPengankut");
            this.Property(t => t.NomorPolisi).HasColumnName("NomorPolisi");
            this.Property(t => t.JumlahKemasan).HasColumnName("JumlahKemasan");
            this.Property(t => t.JenisKemasan).HasColumnName("JenisKemasan");
            this.Property(t => t.JenisTrans).HasColumnName("JenisTrans");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
            this.Property(t => t.TglPendaftaran).HasColumnName("TglPendaftaran");
            this.Property(t => t.NoInvoice).HasColumnName("NoInvoice");
            this.Property(t => t.FinalDestination).HasColumnName("FinalDestination");
            this.Property(t => t.NomorPengajuan).HasColumnName("NomorPengajuan");
            this.Property(t => t.BeratKotor).HasColumnName("BeratKotor");
            this.Property(t => t.BeratBersih).HasColumnName("BeratBersih");
            this.Property(t => t.NPWPCustomer).HasColumnName("NPWPCustomer");
            this.Property(t => t.NamaCustomer).HasColumnName("NamaCustomer");
            this.Property(t => t.NomorIzinPTBCustomer).HasColumnName("NomorIzinPTBCustomer");
            this.Property(t => t.AlamatCustomer).HasColumnName("AlamatCustomer");
            this.Property(t => t.PosTarifHS).HasColumnName("PosTarifHS");
            this.Property(t => t.TanggalKontrak).HasColumnName("TanggalKontrak");
            this.Property(t => t.JenisValutaAsing).HasColumnName("JenisValutaAsing");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.NPWPSender).HasColumnName("NPWPSender");
            this.Property(t => t.NamaSender).HasColumnName("NamaSender");
            this.Property(t => t.NomorIzinPTBSender).HasColumnName("NomorIzinPTBSender");
            this.Property(t => t.AlamatSender).HasColumnName("AlamatSender");
            this.Property(t => t.KantorAsal).HasColumnName("KantorAsal");
            this.Property(t => t.KantorTujuan).HasColumnName("KantorTujuan");
            this.Property(t => t.JenisTPBAsal).HasColumnName("JenisTPBAsal");
            this.Property(t => t.JenisTPBTujuan).HasColumnName("JenisTPBTujuan");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.NoSegel).HasColumnName("NoSegel");
            this.Property(t => t.IdrRate).HasColumnName("IdrRate");
        }
    }
}
