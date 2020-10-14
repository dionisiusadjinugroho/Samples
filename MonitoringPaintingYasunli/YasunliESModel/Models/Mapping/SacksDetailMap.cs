using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SacksDetailMap : EntityTypeConfiguration<SacksDetail>
    {
        public SacksDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SackId, t.DocumentNo, t.FromDocumentNo });

            // Properties
            this.Property(t => t.SackId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.DocumentNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.FromDocumentNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SacksDetail", "Inventory");
            this.Property(t => t.SackId).HasColumnName("SackId");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.FromDocumentNo).HasColumnName("FromDocumentNo");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Created_Date).HasColumnName("Created_Date");
        }
    }
}
