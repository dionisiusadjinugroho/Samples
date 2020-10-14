using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SamplingCMMDetailMap : EntityTypeConfiguration<SamplingCMMDetail>
    {
        public SamplingCMMDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.SamplingCMMDetailId);

            // Properties
            this.Property(t => t.NPK)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.Char)
                .HasMaxLength(50);

            this.Property(t => t.Result)
                .HasMaxLength(50);

            this.Property(t => t.UL)
                .HasMaxLength(50);

            this.Property(t => t.LL)
                .HasMaxLength(50);

            this.Property(t => t.STD)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("SamplingCMMDetail", "Inventory");
            this.Property(t => t.SamplingCMMDetailId).HasColumnName("SamplingCMMDetailId");
            this.Property(t => t.NPK).HasColumnName("NPK");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.Char).HasColumnName("Char");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.JobNo).HasColumnName("JobNo");
            this.Property(t => t.UL).HasColumnName("UL");
            this.Property(t => t.LL).HasColumnName("LL");
            this.Property(t => t.STD).HasColumnName("STD");
        }
    }
}
