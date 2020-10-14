using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemSkillMappingMap : EntityTypeConfiguration<ItemSkillMapping>
    {
        public ItemSkillMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.EndBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemSkillMapping", "Inventory");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EndBy).HasColumnName("EndBy");
            this.Property(t => t.Score).HasColumnName("Score");
        }
    }
}
