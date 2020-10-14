using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MaterialReceivingDetailMap : EntityTypeConfiguration<MaterialReceivingDetail>
    {
        public MaterialReceivingDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailID);

            // Properties
            this.Property(t => t.ReceivingID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PONo)
                .HasMaxLength(100);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.LotNumber)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialReceivingDetail", "Inventory");
            this.Property(t => t.DetailID).HasColumnName("DetailID");
            this.Property(t => t.ReceivingID).HasColumnName("ReceivingID");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.PODetailID).HasColumnName("PODetailID");

            // Relationships
            this.HasRequired(t => t.MaterialReceiving)
                .WithMany(t => t.MaterialReceivingDetails)
                .HasForeignKey(d => d.ReceivingID);

        }
    }
}
