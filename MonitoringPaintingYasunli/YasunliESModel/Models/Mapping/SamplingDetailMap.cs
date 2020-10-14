using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SamplingDetailMap : EntityTypeConfiguration<SamplingDetail>
    {
        public SamplingDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.SamplingDetailID);

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

            this.Property(t => t.Judgement)
                .HasMaxLength(50);

            this.Property(t => t.NPKOperator)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SamplingDetail", "Inventory");
            this.Property(t => t.SamplingDetailID).HasColumnName("SamplingDetailID");
            this.Property(t => t.NPK).HasColumnName("NPK");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.Char).HasColumnName("Char");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.JobNo).HasColumnName("JobNo");
            this.Property(t => t.UL).HasColumnName("UL");
            this.Property(t => t.LL).HasColumnName("LL");
            this.Property(t => t.STD).HasColumnName("STD");
            this.Property(t => t.Judgement).HasColumnName("Judgement");
            this.Property(t => t.NPKOperator).HasColumnName("NPKOperator");
        }
    }
}
