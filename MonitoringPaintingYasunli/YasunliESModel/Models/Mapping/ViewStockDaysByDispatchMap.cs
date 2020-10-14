using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewStockDaysByDispatchMap : EntityTypeConfiguration<ViewStockDaysByDispatch>
    {
        public ViewStockDaysByDispatchMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemName, t.MainModel, t.CustomerName });

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.MainModel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MachineGroupID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewStockDaysByDispatch", "Inventory");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.CycleTime).HasColumnName("CycleTime");
            this.Property(t => t.MachineGroupID).HasColumnName("MachineGroupID");
            this.Property(t => t.DailyQtyAverage).HasColumnName("DailyQtyAverage");
            this.Property(t => t.QtyGudang).HasColumnName("QtyGudang");
            this.Property(t => t.QtySudahKeluar).HasColumnName("QtySudahKeluar");
            this.Property(t => t.DaysUsed).HasColumnName("DaysUsed");
            this.Property(t => t.PercentageSent).HasColumnName("PercentageSent");
            this.Property(t => t.PercendageMinus).HasColumnName("PercendageMinus");
            this.Property(t => t.DailyCapacity).HasColumnName("DailyCapacity");
        }
    }
}
