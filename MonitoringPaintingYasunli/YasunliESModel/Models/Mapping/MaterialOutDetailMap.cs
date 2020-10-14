using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MaterialOutDetailMap : EntityTypeConfiguration<MaterialOutDetail>
    {
        public MaterialOutDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailID);

            // Properties
            this.Property(t => t.MaterialOutNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LotNumber)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("MaterialOutDetail", "Inventory");
            this.Property(t => t.DetailID).HasColumnName("DetailID");
            this.Property(t => t.MaterialOutNo).HasColumnName("MaterialOutNo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");

            // Relationships
            this.HasRequired(t => t.Item)
                .WithMany(t => t.MaterialOutDetails)
                .HasForeignKey(d => d.ItemID);
            this.HasRequired(t => t.Item1)
                .WithMany(t => t.MaterialOutDetails1)
                .HasForeignKey(d => d.ItemID);

        }
    }
}
