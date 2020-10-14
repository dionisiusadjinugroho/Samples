using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ProductionChecklistLTDetailMap : EntityTypeConfiguration<ProductionChecklistLTDetail>
    {
        public ProductionChecklistLTDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductionCheckLisLTDetailtId);

            // Properties
            this.Property(t => t.Cause)
                .HasMaxLength(2000);

            this.Property(t => t.Note)
                .HasMaxLength(2000);

            this.Property(t => t.PIC)
                .HasMaxLength(50);

            this.Property(t => t.LeaderProduksi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionChecklistLTDetail", "Shared");
            this.Property(t => t.ProductionCheckLisLTDetailtId).HasColumnName("ProductionCheckLisLTDetailtId");
            this.Property(t => t.ProductionCheckListId).HasColumnName("ProductionCheckListId");
            this.Property(t => t.Cause).HasColumnName("Cause");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.TotalLTMinutes).HasColumnName("TotalLTMinutes");
            this.Property(t => t.PIC).HasColumnName("PIC");
            this.Property(t => t.LeaderProduksi).HasColumnName("LeaderProduksi");
        }
    }
}
