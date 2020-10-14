using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ReprintHistoryMap : EntityTypeConfiguration<ReprintHistory>
    {
        public ReprintHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.LabelFG)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.Position)
                .HasMaxLength(50);

            this.Property(t => t.NextPosition)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReprintHistory", "Inventory");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.LabelFG).HasColumnName("LabelFG");
            this.Property(t => t.CreatedAt).HasColumnName("CreatedAt");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.NextPosition).HasColumnName("NextPosition");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
