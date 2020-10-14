using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SalesReturnDetailMap : EntityTypeConfiguration<SalesReturnDetail>
    {
        public SalesReturnDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailID);

            // Properties
            this.Property(t => t.DetailID)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("SalesReturnDetail", "Inventory");
            this.Property(t => t.DetailID).HasColumnName("DetailID");
            this.Property(t => t.SalesReturnNo).HasColumnName("SalesReturnNo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.UoMID).HasColumnName("UoMID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.PriceD).HasColumnName("PriceD");
        }
    }
}
