using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class vspplistMap : EntityTypeConfiguration<vspplist>
    {
        public vspplistMap()
        {
            // Primary Key
            this.HasKey(t => t.J_Part);

            // Properties
            this.Property(t => t.SPP_No)
                .HasMaxLength(250);

            this.Property(t => t.Customer)
                .HasMaxLength(250);

            this.Property(t => t.Mold_ID)
                .HasMaxLength(281);

            this.Property(t => t.moldid)
                .HasMaxLength(250);

            this.Property(t => t.mold_tooling)
                .HasMaxLength(30);

            this.Property(t => t.mold_material)
                .HasMaxLength(150);

            this.Property(t => t.J_Part)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vspplist", "andon");
            this.Property(t => t.sppid).HasColumnName("sppid");
            this.Property(t => t.SPP_No).HasColumnName("SPP No");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.Mold_ID).HasColumnName("Mold ID");
            this.Property(t => t.Target).HasColumnName("Target");
            this.Property(t => t.CT).HasColumnName("CT");
            this.Property(t => t.DT).HasColumnName("DT");
            this.Property(t => t.moldid).HasColumnName("moldid");
            this.Property(t => t.mold_tooling).HasColumnName("mold_tooling");
            this.Property(t => t.mold_material).HasColumnName("mold_material");
            this.Property(t => t.J_Part).HasColumnName("J.Part");
        }
    }
}
