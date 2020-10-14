using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class NGBoxMap : EntityTypeConfiguration<NGBox>
    {
        public NGBoxMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            this.Property(t => t.NoJobId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NGBox", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.NoJobId).HasColumnName("NoJobId");
        }
    }
}
