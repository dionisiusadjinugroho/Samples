using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailLabelLansirMap : EntityTypeConfiguration<DetailLabelLansir>
    {
        public DetailLabelLansirMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailLabelID);

            // Properties
            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            this.Property(t => t.Leader_Scan)
                .HasMaxLength(50);

            this.Property(t => t.Engineering_Scan)
                .HasMaxLength(50);

            this.Property(t => t.created_pecahan_by)
                .HasMaxLength(50);

            this.Property(t => t.CustomerBarcode)
                .HasMaxLength(50);

            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailLabelLansir", "Shared");
            this.Property(t => t.DetailLabelID).HasColumnName("DetailLabelID");
            this.Property(t => t.LabelID).HasColumnName("LabelID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
            this.Property(t => t.LabelFG).HasColumnName("LabelFG");
            this.Property(t => t.Leader_Scan).HasColumnName("Leader_Scan");
            this.Property(t => t.Engineering_Scan).HasColumnName("Engineering_Scan");
            this.Property(t => t.created_at).HasColumnName("created_at");
            this.Property(t => t.created_pecahan_by).HasColumnName("created_pecahan_by");
            this.Property(t => t.CustomerBarcode).HasColumnName("CustomerBarcode");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.LotGuarantee).HasColumnName("LotGuarantee");
            this.Property(t => t.Z4M).HasColumnName("Z4M");
            this.Property(t => t.SA).HasColumnName("SA");
            this.Property(t => t.EQZD).HasColumnName("EQZD");
        }
    }
}
