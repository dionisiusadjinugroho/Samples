using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class AssemblingMap : EntityTypeConfiguration<Assembling>
    {
        public AssemblingMap()
        {
            // Primary Key
            this.HasKey(t => t.AssemblingId);

            // Properties
            this.Property(t => t.AssemblingId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.BoxType)
                .HasMaxLength(50);

            this.Property(t => t.created_by)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Assembling", "Inventory");
            this.Property(t => t.AssemblingId).HasColumnName("AssemblingId");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.BoxType).HasColumnName("BoxType");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.created_by).HasColumnName("created_by");
        }
    }
}
