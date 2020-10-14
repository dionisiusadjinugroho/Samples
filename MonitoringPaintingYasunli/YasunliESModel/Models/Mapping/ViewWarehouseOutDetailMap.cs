using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewWarehouseOutDetailMap : EntityTypeConfiguration<ViewWarehouseOutDetail>
    {
        public ViewWarehouseOutDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SPPNo, t.ItemCode, t.ItemName, t.MainModel });

            // Properties
            this.Property(t => t.PackageID)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.KirimKe)
                .HasMaxLength(50);

            this.Property(t => t.QCOut)
                .HasMaxLength(306);

            this.Property(t => t.SPPNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InjectionCode)
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.MainModel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BoxType)
                .HasMaxLength(50);

            this.Property(t => t.ADM)
                .HasMaxLength(306);

            this.Property(t => t.Planner)
                .HasMaxLength(306);

            // Table & Column Mappings
            this.ToTable("ViewWarehouseOutDetail");
            this.Property(t => t.PackageID).HasColumnName("PackageID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.KirimKe).HasColumnName("KirimKe");
            this.Property(t => t.QCOut).HasColumnName("QCOut");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.InjectionCode).HasColumnName("InjectionCode");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.SPQ).HasColumnName("SPQ");
            this.Property(t => t.BoxType).HasColumnName("BoxType");
            this.Property(t => t.ADM).HasColumnName("ADM");
            this.Property(t => t.Planner).HasColumnName("Planner");
        }
    }
}
