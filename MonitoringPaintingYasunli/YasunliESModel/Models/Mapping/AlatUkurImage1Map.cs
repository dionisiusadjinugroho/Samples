using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class AlatUkurImage1Map : EntityTypeConfiguration<AlatUkurImage1>
    {
        public AlatUkurImage1Map()
        {
            // Primary Key
            this.HasKey(t => t.NoIdt);

            // Properties
            this.Property(t => t.NoRegister)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AlatUkurImage", "Inventory");
            this.Property(t => t.NoRegister).HasColumnName("NoRegister");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.NoIdt).HasColumnName("NoIdt");
        }
    }
}
