using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ProductionCheckListMap : EntityTypeConfiguration<ProductionCheckList>
    {
        public ProductionCheckListMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductionCheckListId);

            // Properties
            this.Property(t => t.SppNo)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductionCheckList", "Shared");
            this.Property(t => t.ProductionCheckListId).HasColumnName("ProductionCheckListId");
            this.Property(t => t.SppNo).HasColumnName("SppNo");
            this.Property(t => t.Shift).HasColumnName("Shift");
            this.Property(t => t.Target).HasColumnName("Target");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.StartHour).HasColumnName("StartHour");
            this.Property(t => t.StopHour).HasColumnName("StopHour");
            this.Property(t => t.WorkHour).HasColumnName("WorkHour");
        }
    }
}
