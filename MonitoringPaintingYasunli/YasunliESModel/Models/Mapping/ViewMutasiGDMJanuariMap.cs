using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewMutasiGDMJanuariMap : EntityTypeConfiguration<ViewMutasiGDMJanuari>
    {
        public ViewMutasiGDMJanuariMap()
        {
            // Primary Key
            this.HasKey(t => new { t.StockOpname, t.Selisih });

            // Properties
            this.Property(t => t.KodeBarang)
                .HasMaxLength(4000);

            this.Property(t => t.Sat)
                .HasMaxLength(50);

            this.Property(t => t.StockOpname)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Selisih)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ket)
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("ViewMutasiGDMJanuari", "Inventory");
            this.Property(t => t.No).HasColumnName("No");
            this.Property(t => t.KodeBarang).HasColumnName("KodeBarang");
            this.Property(t => t.NamaBarang).HasColumnName("NamaBarang");
            this.Property(t => t.Sat).HasColumnName("Sat");
            this.Property(t => t.SaldoAwal).HasColumnName("SaldoAwal");
            this.Property(t => t.Pemasukan).HasColumnName("Pemasukan");
            this.Property(t => t.PemasukanSistem).HasColumnName("PemasukanSistem");
            this.Property(t => t.Pengeluaran).HasColumnName("Pengeluaran");
            this.Property(t => t.Penyesuaian).HasColumnName("Penyesuaian");
            this.Property(t => t.SaldoBuku).HasColumnName("SaldoBuku");
            this.Property(t => t.StockOpname).HasColumnName("StockOpname");
            this.Property(t => t.Selisih).HasColumnName("Selisih");
            this.Property(t => t.Ket).HasColumnName("Ket");
        }
    }
}
