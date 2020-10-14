using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RecycleDetailMap : EntityTypeConfiguration<RecycleDetail>
    {
        public RecycleDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            this.Property(t => t.DocumentNo)
                .HasMaxLength(50);

            this.Property(t => t.JobOrderId)
                .HasMaxLength(50);

            this.Property(t => t.SPPNo)
                .HasMaxLength(50);

            this.Property(t => t.RecycleId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RecycleDetail", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.JobOrderId).HasColumnName("JobOrderId");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.RecycleId).HasColumnName("RecycleId");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
