using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class JenisKerusakanMouldMap : EntityTypeConfiguration<JenisKerusakanMould>
    {
        public JenisKerusakanMouldMap()
        {
            // Primary Key
            this.HasKey(t => t.IdKerusakanMould);

            // Properties
            this.Property(t => t.KerusakanMould)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JenisKerusakanMould", "Inventory");
            this.Property(t => t.IdKerusakanMould).HasColumnName("IdKerusakanMould");
            this.Property(t => t.KerusakanMould).HasColumnName("KerusakanMould");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
        }
    }
}
