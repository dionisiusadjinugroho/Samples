using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RejectImageMap : EntityTypeConfiguration<RejectImage>
    {
        public RejectImageMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemId);

            // Properties
            this.Property(t => t.ItemId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RejectImage", "Quality");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Image).HasColumnName("Image");
        }
    }
}
