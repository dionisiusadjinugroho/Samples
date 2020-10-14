using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MaterialPalletMap : EntityTypeConfiguration<MaterialPallet>
    {
        public MaterialPalletMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialPalletId);

            // Properties
            this.Property(t => t.MaterialPalletId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            this.Property(t => t.ReceivingNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialPallet", "Inventory");
            this.Property(t => t.MaterialPalletId).HasColumnName("MaterialPalletId");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.ReceivingNo).HasColumnName("ReceivingNo");
        }
    }
}
