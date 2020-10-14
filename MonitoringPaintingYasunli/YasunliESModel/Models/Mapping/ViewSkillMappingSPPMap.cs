using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewSkillMappingSPPMap : EntityTypeConfiguration<ViewSkillMappingSPP>
    {
        public ViewSkillMappingSPPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SPPNo, t.CustomerName, t.ItemID, t.ItemName, t.MainModel, t.EmployeeId, t.EmployeeName });

            // Properties
            this.Property(t => t.SPPNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cavity)
                .HasMaxLength(50);

            this.Property(t => t.ToolingID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InjectionCode)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.MainModel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmployeeName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.DepartmentId)
                .HasMaxLength(50);

            this.Property(t => t.Keterangan)
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("ViewSkillMappingSPP", "Inventory");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.IssueDate).HasColumnName("IssueDate");
            this.Property(t => t.Cavity).HasColumnName("Cavity");
            this.Property(t => t.ToolingID).HasColumnName("ToolingID");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.InjectionCode).HasColumnName("InjectionCode");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            this.Property(t => t.DepartmentId).HasColumnName("DepartmentId");
            this.Property(t => t.JamSeharusnyaMasuk).HasColumnName("JamSeharusnyaMasuk");
            this.Property(t => t.JamSeharusnyaPulang).HasColumnName("JamSeharusnyaPulang");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
            this.Property(t => t.Score).HasColumnName("Score");
        }
    }
}
