using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SamplingMap : EntityTypeConfiguration<Sampling>
    {
        public SamplingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BarcodeID, t.Detail, t.NoDokumen });

            // Properties
            this.Property(t => t.BarcodeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NIK)
                .HasMaxLength(50);

            this.Property(t => t.Judge)
                .HasMaxLength(50);

            this.Property(t => t.Detail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NoDokumen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NPKOperator)
                .HasMaxLength(50);

            this.Property(t => t.NPKOperator2)
                .HasMaxLength(50);

            this.Property(t => t.NPKOperator3)
                .HasMaxLength(50);

            this.Property(t => t.NPKOperator4)
                .HasMaxLength(50);

            this.Property(t => t.Criteria)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Sampling", "Quality");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.NIK).HasColumnName("NIK");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.Judge).HasColumnName("Judge");
            this.Property(t => t.Detail).HasColumnName("Detail");
            this.Property(t => t.NoDokumen).HasColumnName("NoDokumen");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.NPKOperator).HasColumnName("NPKOperator");
            this.Property(t => t.NPKOperator2).HasColumnName("NPKOperator2");
            this.Property(t => t.NPKOperator3).HasColumnName("NPKOperator3");
            this.Property(t => t.NPKOperator4).HasColumnName("NPKOperator4");
            this.Property(t => t.LotSize).HasColumnName("LotSize");
            this.Property(t => t.SamplingSize).HasColumnName("SamplingSize");
            this.Property(t => t.NGQty).HasColumnName("NGQty");
            this.Property(t => t.StartSampling).HasColumnName("StartSampling");
            this.Property(t => t.EndSampling).HasColumnName("EndSampling");
            this.Property(t => t.Criteria).HasColumnName("Criteria");
        }
    }
}
