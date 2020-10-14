using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldTransactionDetailMap : EntityTypeConfiguration<MouldTransactionDetail>
    {
        public MouldTransactionDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.DetailId)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Model)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MouldTransactionDetail", "Inventory");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.MouldId).HasColumnName("MouldId");
            this.Property(t => t.NamaMould).HasColumnName("NamaMould");
            this.Property(t => t.Tooling).HasColumnName("Tooling");
            this.Property(t => t.KodeBarang).HasColumnName("KodeBarang");
            this.Property(t => t.Jumlah).HasColumnName("Jumlah");
            this.Property(t => t.Satuan).HasColumnName("Satuan");
            this.Property(t => t.Jenis).HasColumnName("Jenis");
            this.Property(t => t.Berat).HasColumnName("Berat");
            this.Property(t => t.JatuhTempo).HasColumnName("JatuhTempo");
            this.Property(t => t.MouldTransactionId).HasColumnName("MouldTransactionId");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.Model).HasColumnName("Model");
        }
    }
}
