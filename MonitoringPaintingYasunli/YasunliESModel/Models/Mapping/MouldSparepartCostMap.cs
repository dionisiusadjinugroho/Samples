using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldSparepartCostMap : EntityTypeConfiguration<MouldSparepartCost>
    {
        public MouldSparepartCostMap()
        {
            // Primary Key
            this.HasKey(t => t.MouldSparepartCostId);

            // Properties
            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MouldSparepartCost", "Shared");
            this.Property(t => t.MouldSparepartCostId).HasColumnName("MouldSparepartCostId");
            this.Property(t => t.SparepartId).HasColumnName("SparepartId");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyId");
            this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
