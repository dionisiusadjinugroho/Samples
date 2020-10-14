using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ResponseKanbanMap : EntityTypeConfiguration<ResponseKanban>
    {
        public ResponseKanbanMap()
        {
            // Primary Key
            this.HasKey(t => t.KanbanResponseId);

            // Properties
            this.Property(t => t.RequestID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ResponseKanban", "Inventory");
            this.Property(t => t.KanbanResponseId).HasColumnName("KanbanResponseId");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.QtyKeluar).HasColumnName("QtyKeluar");
            this.Property(t => t.QtyRemain).HasColumnName("QtyRemain");
        }
    }
}
