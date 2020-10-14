using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewReworkOutMap : EntityTypeConfiguration<ViewReworkOut>
    {
        public ViewReworkOutMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerName);

            // Properties
            this.Property(t => t.ReworkID)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.MainModel)
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ToolingID)
                .HasMaxLength(50);

            this.Property(t => t.InjectionCode)
                .HasMaxLength(50);

            this.Property(t => t.PICRework)
                .HasMaxLength(306);

            // Table & Column Mappings
            this.ToTable("ViewReworkOut", "Inventory");
            this.Property(t => t.ReworkID).HasColumnName("ReworkID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.created_at).HasColumnName("created_at");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.ToolingID).HasColumnName("ToolingID");
            this.Property(t => t.InjectionCode).HasColumnName("InjectionCode");
            this.Property(t => t.PICRework).HasColumnName("PICRework");
        }
    }
}
