using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemQuantityMap : EntityTypeConfiguration<ItemQuantity>
    {
        public ItemQuantityMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemQuantitiesID);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.DocumentNo)
                .HasMaxLength(50);

            this.Property(t => t.FromDocumentNo)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.FromDiv)
                .HasMaxLength(50);

            this.Property(t => t.ToDiv)
                .HasMaxLength(50);

            this.Property(t => t.admID)
                .HasMaxLength(50);

            this.Property(t => t.plannerID)
                .HasMaxLength(50);

            this.Property(t => t.LocationID)
                .HasMaxLength(50);

            this.Property(t => t.ReceiveBy)
                .HasMaxLength(50);

            this.Property(t => t.TokenId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemQuantities", "Inventory");
            this.Property(t => t.ItemQuantitiesID).HasColumnName("ItemQuantitiesID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Created_Date).HasColumnName("Created_Date");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.FromDocumentNo).HasColumnName("FromDocumentNo");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.FromDiv).HasColumnName("FromDiv");
            this.Property(t => t.ToDiv).HasColumnName("ToDiv");
            this.Property(t => t.admID).HasColumnName("admID");
            this.Property(t => t.plannerID).HasColumnName("plannerID");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.ReceiveBy).HasColumnName("ReceiveBy");
            this.Property(t => t.TokenId).HasColumnName("TokenId");
            this.Property(t => t.TokenDate).HasColumnName("TokenDate");
        }
    }
}
