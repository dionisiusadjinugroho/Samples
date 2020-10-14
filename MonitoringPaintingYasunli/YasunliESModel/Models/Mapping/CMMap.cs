using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class CMMap : EntityTypeConfiguration<CM>
    {
        public CMMap()
        {
            // Primary Key
            this.HasKey(t => t.CMSId);

            // Properties
            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            this.Property(t => t.SPPNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CMS", "Shared");
            this.Property(t => t.CMSId).HasColumnName("CMSId");
            this.Property(t => t.Inspection).HasColumnName("Inspection");
            this.Property(t => t.Cutting).HasColumnName("Cutting");
            this.Property(t => t.Assembling).HasColumnName("Assembling");
            this.Property(t => t.Marking).HasColumnName("Marking");
            this.Property(t => t.Packing).HasColumnName("Packing");
            this.Property(t => t.OperatorQty).HasColumnName("OperatorQty");
            this.Property(t => t.CycleTime).HasColumnName("CycleTime");
            this.Property(t => t.CMSDate).HasColumnName("CMSDate");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
        }
    }
}
