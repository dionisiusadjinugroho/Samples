using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class CMMMap : EntityTypeConfiguration<CMM>
    {
        public CMMMap()
        {
            // Primary Key
            this.HasKey(t => t.CMMID);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.Karakter)
                .HasMaxLength(50);

            this.Property(t => t.standard)
                .HasMaxLength(50);

            this.Property(t => t.Grade)
                .HasMaxLength(50);

            this.Property(t => t.DrawingPage)
                .HasMaxLength(50);

            this.Property(t => t.AddressNo)
                .HasMaxLength(50);

            this.Property(t => t.AddressAlpha)
                .HasMaxLength(50);

            this.Property(t => t.Rev)
                .HasMaxLength(50);

            this.Property(t => t.SymbolNote)
                .HasMaxLength(50);

            this.Property(t => t.MeasureDev1)
                .HasMaxLength(50);

            this.Property(t => t.MeasureDev2)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CMM", "Inventory");
            this.Property(t => t.CMMID).HasColumnName("CMMID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Karakter).HasColumnName("Karakter");
            this.Property(t => t.upperlimit).HasColumnName("upperlimit");
            this.Property(t => t.lowerlimit).HasColumnName("lowerlimit");
            this.Property(t => t.standard).HasColumnName("standard");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.DrawingPage).HasColumnName("DrawingPage");
            this.Property(t => t.AddressNo).HasColumnName("AddressNo");
            this.Property(t => t.AddressAlpha).HasColumnName("AddressAlpha");
            this.Property(t => t.Rev).HasColumnName("Rev");
            this.Property(t => t.SymbolNote).HasColumnName("SymbolNote");
            this.Property(t => t.MeasureDev1).HasColumnName("MeasureDev1");
            this.Property(t => t.MeasureDev2).HasColumnName("MeasureDev2");
            this.Property(t => t.Date).HasColumnName("Date");
        }
    }
}
