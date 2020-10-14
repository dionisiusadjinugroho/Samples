using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class KanbanMap : EntityTypeConfiguration<Kanban>
    {
        public KanbanMap()
        {
            // Primary Key
            this.HasKey(t => t.KanbanId);

            // Properties
            this.Property(t => t.CustomerId)
                .HasMaxLength(50);

            this.Property(t => t.KanbanNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Kanban", "Inventory");
            this.Property(t => t.KanbanId).HasColumnName("KanbanId");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.TransitTime).HasColumnName("TransitTime");
            this.Property(t => t.KanbanNo).HasColumnName("KanbanNo");
            this.Property(t => t.ETA).HasColumnName("ETA");
        }
    }
}
