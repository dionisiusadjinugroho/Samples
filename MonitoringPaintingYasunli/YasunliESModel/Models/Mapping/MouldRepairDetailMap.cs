using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldRepairDetailMap : EntityTypeConfiguration<MouldRepairDetail>
    {
        public MouldRepairDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailMouldRepairId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MouldRepairDetail", "Shared");
            this.Property(t => t.DetailMouldRepairId).HasColumnName("DetailMouldRepairId");
            this.Property(t => t.MouldRepairId).HasColumnName("MouldRepairId");
            this.Property(t => t.SparepartId).HasColumnName("SparepartId");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
