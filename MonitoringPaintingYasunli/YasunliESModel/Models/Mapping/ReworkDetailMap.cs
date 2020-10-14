using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ReworkDetailMap : EntityTypeConfiguration<ReworkDetail>
    {
        public ReworkDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ReworkDetailID);

            // Properties
            this.Property(t => t.ReworkID)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.Receive_By)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            this.Property(t => t.Position)
                .HasMaxLength(50);

            this.Property(t => t.NextPosition)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReworkDetail", "Inventory");
            this.Property(t => t.ReworkDetailID).HasColumnName("ReworkDetailID");
            this.Property(t => t.ReworkID).HasColumnName("ReworkID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Receive_By).HasColumnName("Receive_By");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.NextPosition).HasColumnName("NextPosition");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Model).HasColumnName("Model");
        }
    }
}
