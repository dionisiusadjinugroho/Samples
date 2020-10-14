using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class callhistoryMap : EntityTypeConfiguration<callhistory>
    {
        public callhistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.callseq);

            // Properties
            this.Property(t => t.personid)
                .HasMaxLength(65535);

            this.Property(t => t.iscomplete)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("callhistory", "andon");
            this.Property(t => t.callseq).HasColumnName("callseq");
            this.Property(t => t.sppseq).HasColumnName("sppseq");
            this.Property(t => t.personid).HasColumnName("personid");
            this.Property(t => t.idcall).HasColumnName("idcall");
            this.Property(t => t.epochstart).HasColumnName("epochstart");
            this.Property(t => t.epochend).HasColumnName("epochend");
            this.Property(t => t.iscomplete).HasColumnName("iscomplete");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
