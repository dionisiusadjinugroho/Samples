using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class AlatUkurMap : EntityTypeConfiguration<AlatUkur>
    {
        public AlatUkurMap()
        {
            // Primary Key
            this.HasKey(t => t.NoRegister);

            // Properties
            this.Property(t => t.NoRegister)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NamaAlatUkur)
                .HasMaxLength(50);

            this.Property(t => t.Range)
                .HasMaxLength(50);

            this.Property(t => t.NoSeri)
                .HasMaxLength(50);

            this.Property(t => t.Merk)
                .HasMaxLength(50);

            this.Property(t => t.FactPengguna)
                .HasMaxLength(50);

            this.Property(t => t.DeptPengguna)
                .HasMaxLength(50);

            this.Property(t => t.Grade)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AlatUkur", "Inventory");
            this.Property(t => t.NoRegister).HasColumnName("NoRegister");
            this.Property(t => t.NamaAlatUkur).HasColumnName("NamaAlatUkur");
            this.Property(t => t.Range).HasColumnName("Range");
            this.Property(t => t.NoSeri).HasColumnName("NoSeri");
            this.Property(t => t.Merk).HasColumnName("Merk");
            this.Property(t => t.TglPembelian).HasColumnName("TglPembelian");
            this.Property(t => t.FactPengguna).HasColumnName("FactPengguna");
            this.Property(t => t.DeptPengguna).HasColumnName("DeptPengguna");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.Kalibrasi).HasColumnName("Kalibrasi");
            this.Property(t => t.Verifikasi).HasColumnName("Verifikasi");
        }
    }
}
