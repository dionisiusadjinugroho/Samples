using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class TransactionScrapDetailMap : EntityTypeConfiguration<TransactionScrapDetail>
    {
        public TransactionScrapDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailID);

            // Properties
            this.Property(t => t.DetailID)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.TransactionScrapNo)
                .HasMaxLength(250);

            this.Property(t => t.ItemID)
                .HasMaxLength(250);

            this.Property(t => t.ItemName)
                .HasMaxLength(250);

            this.Property(t => t.UoMID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TransactionScrapDetail", "Inventory");
            this.Property(t => t.DetailID).HasColumnName("DetailID");
            this.Property(t => t.TransactionScrapNo).HasColumnName("TransactionScrapNo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.GrossWeight).HasColumnName("GrossWeight");
            this.Property(t => t.UoMID).HasColumnName("UoMID");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
        }
    }
}
