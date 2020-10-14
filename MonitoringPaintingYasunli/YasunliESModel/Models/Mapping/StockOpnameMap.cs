using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class StockOpnameMap : EntityTypeConfiguration<StockOpname>
    {
        public StockOpnameMap()
        {
            // Primary Key
            this.HasKey(t => t.StockOpnameID);

            // Properties
            this.Property(t => t.StockOpnameID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.TableName)
                .HasMaxLength(50);

            this.Property(t => t.TablePrinting)
                .HasMaxLength(50);

            this.Property(t => t.TablePainting)
                .HasMaxLength(50);

            this.Property(t => t.TableAssembling)
                .HasMaxLength(50);

            this.Property(t => t.TableFinishing)
                .HasMaxLength(50);

            this.Property(t => t.TableGudang)
                .HasMaxLength(50);

            this.Property(t => t.TableDelivery)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("StockOpname", "Shared");
            this.Property(t => t.StockOpnameID).HasColumnName("StockOpnameID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Started).HasColumnName("Started");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.Printing).HasColumnName("Printing");
            this.Property(t => t.Painting).HasColumnName("Painting");
            this.Property(t => t.Assembling).HasColumnName("Assembling");
            this.Property(t => t.Finishing).HasColumnName("Finishing");
            this.Property(t => t.Gudang).HasColumnName("Gudang");
            this.Property(t => t.Delivery).HasColumnName("Delivery");
            this.Property(t => t.TablePrinting).HasColumnName("TablePrinting");
            this.Property(t => t.TablePainting).HasColumnName("TablePainting");
            this.Property(t => t.TableAssembling).HasColumnName("TableAssembling");
            this.Property(t => t.TableFinishing).HasColumnName("TableFinishing");
            this.Property(t => t.TableGudang).HasColumnName("TableGudang");
            this.Property(t => t.TableDelivery).HasColumnName("TableDelivery");
        }
    }
}
