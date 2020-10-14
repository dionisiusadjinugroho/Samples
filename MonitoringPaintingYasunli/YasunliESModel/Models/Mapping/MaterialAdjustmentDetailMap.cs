using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MaterialAdjustmentDetailMap : EntityTypeConfiguration<MaterialAdjustmentDetail>
    {
        public MaterialAdjustmentDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DetailID, t.MaterialAdjustmentNo, t.ItemID });

            // Properties
            this.Property(t => t.DetailID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MaterialAdjustmentNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LotNumber)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("MaterialAdjustmentDetail", "Inventory");
            this.Property(t => t.DetailID).HasColumnName("DetailID");
            this.Property(t => t.MaterialAdjustmentNo).HasColumnName("MaterialAdjustmentNo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");

            // Relationships
            this.HasRequired(t => t.Item)
                .WithMany(t => t.MaterialAdjustmentDetails)
                .HasForeignKey(d => d.ItemID);
            this.HasRequired(t => t.Item1)
                .WithMany(t => t.MaterialAdjustmentDetails1)
                .HasForeignKey(d => d.ItemID);
            this.HasRequired(t => t.MaterialAdjustment)
                .WithMany(t => t.MaterialAdjustmentDetails)
                .HasForeignKey(d => d.MaterialAdjustmentNo);

        }
    }
}
