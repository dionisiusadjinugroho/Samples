using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class JenisKerusakanPartMap : EntityTypeConfiguration<JenisKerusakanPart>
    {
        public JenisKerusakanPartMap()
        {
            // Primary Key
            this.HasKey(t => t.IdKerusakanPart);

            // Properties
            this.Property(t => t.KerusakanPart)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JenisKerusakanPart", "Inventory");
            this.Property(t => t.IdKerusakanPart).HasColumnName("IdKerusakanPart");
            this.Property(t => t.KerusakanPart).HasColumnName("KerusakanPart");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
        }
    }
}
