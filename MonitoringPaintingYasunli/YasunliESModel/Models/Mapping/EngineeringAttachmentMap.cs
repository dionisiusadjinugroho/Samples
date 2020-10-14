using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class EngineeringAttachmentMap : EntityTypeConfiguration<EngineeringAttachment>
    {
        public EngineeringAttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.EngineeringAttachmentId);

            // Properties
            this.Property(t => t.AttachmentType)
                .HasMaxLength(50);

            this.Property(t => t.Attachmentname)
                .HasMaxLength(50);

            this.Property(t => t.FileExt)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EngineeringAttachment", "Shared");
            this.Property(t => t.EngineeringAttachmentId).HasColumnName("EngineeringAttachmentId");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.AttachmentDate).HasColumnName("AttachmentDate");
            this.Property(t => t.AttachmentType).HasColumnName("AttachmentType");
            this.Property(t => t.Attachmentname).HasColumnName("Attachmentname");
            this.Property(t => t.EngineeringJobId).HasColumnName("EngineeringJobId");
            this.Property(t => t.FileExt).HasColumnName("FileExt");
        }
    }
}
