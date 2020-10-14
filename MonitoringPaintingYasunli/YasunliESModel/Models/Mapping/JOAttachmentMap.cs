using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class JOAttachmentMap : EntityTypeConfiguration<JOAttachment>
    {
        public JOAttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.JOAttachmentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("JOAttachment", "Shared");
            this.Property(t => t.JOAttachmentID).HasColumnName("JOAttachmentID");
            this.Property(t => t.JobOrderID).HasColumnName("JobOrderID");
            this.Property(t => t.PDFAttachment).HasColumnName("PDFAttachment");
            this.Property(t => t.AttachmentDate).HasColumnName("AttachmentDate");
            this.Property(t => t.PictureENG).HasColumnName("PictureENG");
        }
    }
}
