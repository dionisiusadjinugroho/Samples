using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SamplingSizeNodeMap : EntityTypeConfiguration<SamplingSizeNode>
    {
        public SamplingSizeNodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SamplingLevel, t.LetterCode });

            // Properties
            this.Property(t => t.SamplingLevel)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LetterCode)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("SamplingSizeNode", "Inventory");
            this.Property(t => t.SamplingLevel).HasColumnName("SamplingLevel");
            this.Property(t => t.LotSizeMin).HasColumnName("LotSizeMin");
            this.Property(t => t.LotSizeMax).HasColumnName("LotSizeMax");
            this.Property(t => t.LetterCode).HasColumnName("LetterCode");
        }
    }
}
