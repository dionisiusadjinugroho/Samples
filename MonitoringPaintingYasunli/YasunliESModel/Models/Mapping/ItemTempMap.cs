using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemTempMap : EntityTypeConfiguration<ItemTemp>
    {
        public ItemTempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemID, t.CustomerID, t.MouldID, t.DivisionID, t.ItemCode, t.ItemName, t.Category, t.MainModel, t.MaterialType });

            // Properties
            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UoMID)
                .HasMaxLength(50);

            this.Property(t => t.UomItemWeight)
                .HasMaxLength(50);

            this.Property(t => t.UomItemRunner)
                .HasMaxLength(50);

            this.Property(t => t.MachineGroupID)
                .HasMaxLength(50);

            this.Property(t => t.VendorID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MouldID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DivisionID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.ItemComponent)
                .HasMaxLength(50);

            this.Property(t => t.Category)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VersionInfo)
                .HasMaxLength(10);

            this.Property(t => t.LastModifiedBy)
                .HasMaxLength(50);

            this.Property(t => t.MachineName)
                .HasMaxLength(50);

            this.Property(t => t.MDI)
                .HasMaxLength(50);

            this.Property(t => t.MainModel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaterialType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.closed_by)
                .HasMaxLength(50);

            this.Property(t => t.Colour)
                .HasMaxLength(50);

            this.Property(t => t.Product)
                .HasMaxLength(50);

            this.Property(t => t.Side)
                .HasMaxLength(50);

            this.Property(t => t.QualityLevel)
                .HasMaxLength(50);

            this.Property(t => t.Gate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemTemp");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.UoMID).HasColumnName("UoMID");
            this.Property(t => t.UomItemWeight).HasColumnName("UomItemWeight");
            this.Property(t => t.UomItemRunner).HasColumnName("UomItemRunner");
            this.Property(t => t.MachineGroupID).HasColumnName("MachineGroupID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.MouldID).HasColumnName("MouldID");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.ItemWeight).HasColumnName("ItemWeight");
            this.Property(t => t.RunnerWeight).HasColumnName("RunnerWeight");
            this.Property(t => t.CycleTime).HasColumnName("CycleTime");
            this.Property(t => t.ItemComponent).HasColumnName("ItemComponent");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.UsageStop).HasColumnName("UsageStop");
            this.Property(t => t.VersionInfo).HasColumnName("VersionInfo");
            this.Property(t => t.ValidStart).HasColumnName("ValidStart");
            this.Property(t => t.ValidUntil).HasColumnName("ValidUntil");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.MDI).HasColumnName("MDI");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.MaterialType).HasColumnName("MaterialType");
            this.Property(t => t.close_date).HasColumnName("close_date");
            this.Property(t => t.closed_by).HasColumnName("closed_by");
            this.Property(t => t.Colour).HasColumnName("Colour");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.Side).HasColumnName("Side");
            this.Property(t => t.QualityLevel).HasColumnName("QualityLevel");
            this.Property(t => t.ManPower).HasColumnName("ManPower");
            this.Property(t => t.AQL).HasColumnName("AQL");
            this.Property(t => t.Gate).HasColumnName("Gate");
        }
    }
}
