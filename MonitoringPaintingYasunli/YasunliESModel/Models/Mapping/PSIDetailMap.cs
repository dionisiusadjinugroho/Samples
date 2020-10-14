using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PSIDetailMap : EntityTypeConfiguration<PSIDetail>
    {
        public PSIDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.PSIDetailId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PSIDetail", "Inventory");
            this.Property(t => t.PSIDetailId).HasColumnName("PSIDetailId");
            this.Property(t => t.PSIUniqueId).HasColumnName("PSIUniqueId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
