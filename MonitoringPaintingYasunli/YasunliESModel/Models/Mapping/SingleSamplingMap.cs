using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SingleSamplingMap : EntityTypeConfiguration<SingleSampling>
    {
        public SingleSamplingMap()
        {
            // Primary Key
            this.HasKey(t => t.SingleSamplingId);

            // Properties
            this.Property(t => t.LetterCode)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("SingleSampling", "Quality");
            this.Property(t => t.LetterCode).HasColumnName("LetterCode");
            this.Property(t => t.SamplingSize).HasColumnName("SamplingSize");
            this.Property(t => t.AQL).HasColumnName("AQL");
            this.Property(t => t.RejectQty).HasColumnName("RejectQty");
            this.Property(t => t.SingleSamplingId).HasColumnName("SingleSamplingId");
        }
    }
}
