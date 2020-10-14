using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SackMap : EntityTypeConfiguration<Sack>
    {
        public SackMap()
        {
            // Primary Key
            this.HasKey(t => t.SackId);

            // Properties
            this.Property(t => t.SackId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.DocumentNo)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sacks", "Inventory");
            this.Property(t => t.SackId).HasColumnName("SackId");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Last_Updated).HasColumnName("Last_Updated");
        }
    }
}
