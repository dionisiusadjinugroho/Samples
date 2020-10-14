using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class EngineeringJobOrderMap : EntityTypeConfiguration<EngineeringJobOrder>
    {
        public EngineeringJobOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.EngineeringJobId);

            // Properties
            this.Property(t => t.ReportedBy)
                .HasMaxLength(50);

            this.Property(t => t.Document1Ext)
                .HasMaxLength(50);

            this.Property(t => t.Document2Ext)
                .HasMaxLength(50);

            this.Property(t => t.Document3Ext)
                .HasMaxLength(50);

            this.Property(t => t.Drawing1Ext)
                .HasMaxLength(50);

            this.Property(t => t.Drawing2Ext)
                .HasMaxLength(50);

            this.Property(t => t.Document4Ext)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EngineeringJobOrder", "Inventory");
            this.Property(t => t.EngineeringJobId).HasColumnName("EngineeringJobId");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.ReportDate).HasColumnName("ReportDate");
            this.Property(t => t.Event).HasColumnName("Event");
            this.Property(t => t.TrialNo).HasColumnName("TrialNo");
            this.Property(t => t.Document1).HasColumnName("Document1");
            this.Property(t => t.Document2).HasColumnName("Document2");
            this.Property(t => t.Document3).HasColumnName("Document3");
            this.Property(t => t.Drawing1).HasColumnName("Drawing1");
            this.Property(t => t.Drawing2).HasColumnName("Drawing2");
            this.Property(t => t.NextEvent).HasColumnName("NextEvent");
            this.Property(t => t.NextEventDate).HasColumnName("NextEventDate");
            this.Property(t => t.ReportedBy).HasColumnName("ReportedBy");
            this.Property(t => t.Document1Ext).HasColumnName("Document1Ext");
            this.Property(t => t.Document2Ext).HasColumnName("Document2Ext");
            this.Property(t => t.Document3Ext).HasColumnName("Document3Ext");
            this.Property(t => t.Drawing1Ext).HasColumnName("Drawing1Ext");
            this.Property(t => t.Drawing2Ext).HasColumnName("Drawing2Ext");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.Document4Ext).HasColumnName("Document4Ext");
            this.Property(t => t.Document4).HasColumnName("Document4");
        }
    }
}
