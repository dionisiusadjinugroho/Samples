using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ClaimImageMap : EntityTypeConfiguration<ClaimImage>
    {
        public ClaimImageMap()
        {
            // Primary Key
            this.HasKey(t => t.ClaimImageId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClaimImage", "Inventory");
            this.Property(t => t.ClaimImageId).HasColumnName("ClaimImageId");
            this.Property(t => t.ClaimId).HasColumnName("ClaimId");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.AttachmentDate).HasColumnName("AttachmentDate");
        }
    }
}
