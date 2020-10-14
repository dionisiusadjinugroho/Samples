using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RecycleMap : EntityTypeConfiguration<Recycle>
    {
        public RecycleMap()
        {
            // Primary Key
            this.HasKey(t => t.RecycleId);

            // Properties
            this.Property(t => t.RecycleId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.created_by)
                .HasMaxLength(50);

            this.Property(t => t.administrator)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Recycle", "Inventory");
            this.Property(t => t.RecycleId).HasColumnName("RecycleId");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.administrator).HasColumnName("administrator");
        }
    }
}
