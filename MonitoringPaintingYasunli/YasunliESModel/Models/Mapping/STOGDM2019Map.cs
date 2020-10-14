using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class STOGDM2019Map : EntityTypeConfiguration<STOGDM2019>
    {
        public STOGDM2019Map()
        {
            // Primary Key
            this.HasKey(t => t.ItemId);

            // Properties
            this.Property(t => t.Urutan)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ItemId)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            this.Property(t => t.UoM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("STOGDM2019");
            this.Property(t => t.Urutan).HasColumnName("Urutan");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.UoM).HasColumnName("UoM");
            this.Property(t => t.SaldoAwal).HasColumnName("SaldoAwal");
            this.Property(t => t.Pemasukan).HasColumnName("Pemasukan");
            this.Property(t => t.Pengeluaran).HasColumnName("Pengeluaran");
            this.Property(t => t.SaldoBuku).HasColumnName("SaldoBuku");
            this.Property(t => t.SaldoAwalR).HasColumnName("SaldoAwalR");
            this.Property(t => t.PemasukanR).HasColumnName("PemasukanR");
            this.Property(t => t.PengeluaranR).HasColumnName("PengeluaranR");
        }
    }
}
