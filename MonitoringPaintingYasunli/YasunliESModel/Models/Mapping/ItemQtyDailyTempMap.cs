using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemQtyDailyTempMap : EntityTypeConfiguration<ItemQtyDailyTemp>
    {
        public ItemQtyDailyTempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemId, t.Qty, t.Date });

            // Properties
            this.Property(t => t.ItemId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Qty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ItemQtyDailyTemp");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Date).HasColumnName("Date");
        }
    }
}