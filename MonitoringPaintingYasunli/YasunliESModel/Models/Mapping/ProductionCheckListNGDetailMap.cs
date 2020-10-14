using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ProductionCheckListNGDetailMap : EntityTypeConfiguration<ProductionCheckListNGDetail>
    {
        public ProductionCheckListNGDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductionCheckLisNGDetailtId);

            // Properties
            this.Property(t => t.NGType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionCheckListNGDetail", "Shared");
            this.Property(t => t.ProductionCheckLisNGDetailtId).HasColumnName("ProductionCheckLisNGDetailtId");
            this.Property(t => t.ProductionCheckListId).HasColumnName("ProductionCheckListId");
            this.Property(t => t.NGType).HasColumnName("NGType");
            this.Property(t => t.TimeRange).HasColumnName("TimeRange");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
