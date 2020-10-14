using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MST_RAWMap : EntityTypeConfiguration<MST_RAW>
    {
        public MST_RAWMap()
        {
            // Primary Key
            this.HasKey(t => t.FCID);

            // Properties
            this.Property(t => t.FCID)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.FCNAME)
                .HasMaxLength(120);

            this.Property(t => t.FCID_ALT)
                .HasMaxLength(35);

            this.Property(t => t.FCPRC_CODE)
                .HasMaxLength(20);

            this.Property(t => t.FCID_CUST)
                .HasMaxLength(10);

            this.Property(t => t.FCID_SUPL)
                .HasMaxLength(10);

            this.Property(t => t.FCMAIN)
                .HasMaxLength(10);

            this.Property(t => t.FCSUB)
                .HasMaxLength(10);

            this.Property(t => t.FC_PO)
                .HasMaxLength(10);

            this.Property(t => t.FCRACK)
                .HasMaxLength(10);

            this.Property(t => t.FCMETHODE)
                .HasMaxLength(10);

            this.Property(t => t.FCPACKING)
                .HasMaxLength(10);

            this.Property(t => t.FCMIXING)
                .HasMaxLength(30);

            this.Property(t => t.FCDOC)
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("MST_RAW");
            this.Property(t => t.FCID).HasColumnName("FCID");
            this.Property(t => t.FCNAME).HasColumnName("FCNAME");
            this.Property(t => t.FCID_ALT).HasColumnName("FCID_ALT");
            this.Property(t => t.FCPRC_CODE).HasColumnName("FCPRC_CODE");
            this.Property(t => t.FCID_CUST).HasColumnName("FCID_CUST");
            this.Property(t => t.FCID_SUPL).HasColumnName("FCID_SUPL");
            this.Property(t => t.FCMAIN).HasColumnName("FCMAIN");
            this.Property(t => t.FCSUB).HasColumnName("FCSUB");
            this.Property(t => t.FC_PO).HasColumnName("FC_PO");
            this.Property(t => t.FCRACK).HasColumnName("FCRACK");
            this.Property(t => t.FCMETHODE).HasColumnName("FCMETHODE");
            this.Property(t => t.FCPACKING).HasColumnName("FCPACKING");
            this.Property(t => t.FCMIXING).HasColumnName("FCMIXING");
            this.Property(t => t.FNMIN).HasColumnName("FNMIN");
            this.Property(t => t.FNMAX).HasColumnName("FNMAX");
            this.Property(t => t.FNSALE_A).HasColumnName("FNSALE_A");
            this.Property(t => t.FNSALE_B).HasColumnName("FNSALE_B");
            this.Property(t => t.FNSALE_C).HasColumnName("FNSALE_C");
            this.Property(t => t.FNSALE_D).HasColumnName("FNSALE_D");
            this.Property(t => t.FNSALE_E).HasColumnName("FNSALE_E");
            this.Property(t => t.FNSALE_F).HasColumnName("FNSALE_F");
            this.Property(t => t.FNSALE_G).HasColumnName("FNSALE_G");
            this.Property(t => t.FNDISCOUNT).HasColumnName("FNDISCOUNT");
            this.Property(t => t.FLCONTINUE).HasColumnName("FLCONTINUE");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.FCDOC).HasColumnName("FCDOC");
        }
    }
}
