using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RequestOrderDetailMap : EntityTypeConfiguration<RequestOrderDetail>
    {
        public RequestOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestOrderDetailID);

            // Properties
            this.Property(t => t.RequestID)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.SPPNo)
                .HasMaxLength(50);

            this.Property(t => t.Tooling)
                .HasMaxLength(10);

            this.Property(t => t.Cavity)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("RequestOrderDetail", "Inventory");
            this.Property(t => t.RequestOrderDetailID).HasColumnName("RequestOrderDetailID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Tanggal).HasColumnName("Tanggal");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.Tooling).HasColumnName("Tooling");
            this.Property(t => t.Cavity).HasColumnName("Cavity");
        }
    }
}
