using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class UoMMap : EntityTypeConfiguration<UoM>
    {
        public UoMMap()
        {
            // Primary Key
            this.HasKey(t => t.UoMID);

            // Properties
            this.Property(t => t.UoMID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BaseUnit)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UoM", "Inventory");
            this.Property(t => t.UoMID).HasColumnName("UoMID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.BaseUnit).HasColumnName("BaseUnit");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
