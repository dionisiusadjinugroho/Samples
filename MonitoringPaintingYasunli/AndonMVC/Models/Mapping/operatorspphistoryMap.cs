using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class operatorspphistoryMap : EntityTypeConfiguration<operatorspphistory>
    {
        public operatorspphistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.opsppseq);

            // Properties
            this.Property(t => t.operatorid)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("operatorspphistory", "andon");
            this.Property(t => t.opsppseq).HasColumnName("opsppseq");
            this.Property(t => t.operatorid).HasColumnName("operatorid");
            this.Property(t => t.sppseq).HasColumnName("sppseq");
            this.Property(t => t.epochstart).HasColumnName("epochstart");
            this.Property(t => t.epochend).HasColumnName("epochend");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
