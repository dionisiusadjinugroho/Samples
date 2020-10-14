using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewJOAssyItemListMap : EntityTypeConfiguration<ViewJOAssyItemList>
    {
        public ViewJOAssyItemListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemID, t.ItemName, t.MainModel });

            // Properties
            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.MainModel)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewJOAssyItemList");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
