using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class EngineeringCaseMap : EntityTypeConfiguration<EngineeringCase>
    {
        public EngineeringCaseMap()
        {
            // Primary Key
            this.HasKey(t => t.CaseId);

            // Properties
            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.MouldId)
                .HasMaxLength(50);

            this.Property(t => t.ToolingId)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.MouldDrawingId)
                .HasMaxLength(50);

            this.Property(t => t.MouldDrawingExt)
                .HasMaxLength(50);

            this.Property(t => t.PartDrawingExt)
                .HasMaxLength(50);

            this.Property(t => t.BoxType)
                .HasMaxLength(50);

            this.Property(t => t.TrayType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EngineeringCase", "Inventory");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.CaseDate).HasColumnName("CaseDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Detail).HasColumnName("Detail");
            this.Property(t => t.MouldId).HasColumnName("MouldId");
            this.Property(t => t.ToolingId).HasColumnName("ToolingId");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.MouldDrawing).HasColumnName("MouldDrawing");
            this.Property(t => t.PartDrawing).HasColumnName("PartDrawing");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.MouldDrawingId).HasColumnName("MouldDrawingId");
            this.Property(t => t.MouldDrawingExt).HasColumnName("MouldDrawingExt");
            this.Property(t => t.PartDrawingExt).HasColumnName("PartDrawingExt");
            this.Property(t => t.BoxType).HasColumnName("BoxType");
            this.Property(t => t.TrayType).HasColumnName("TrayType");
            this.Property(t => t.BoxQty).HasColumnName("BoxQty");
            this.Property(t => t.TrayQty).HasColumnName("TrayQty");
        }
    }
}
