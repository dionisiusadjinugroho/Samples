using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class sppFormMap : EntityTypeConfiguration<sppform>
    {
        public sppFormMap()
        {
            // Primary Key
            this.HasKey(t => t.spp_name);



            // Table & Column Mappings
            this.ToTable("sppform", "andon");
            this.Property(t => t.spp_name).HasColumnName("spp_name");
            this.Property(t => t.tanggal).HasColumnName("tanggal");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.part_code).HasColumnName("part_code");
            this.Property(t => t.naik_mold).HasColumnName("naik_mold");
            this.Property(t => t.nama_item).HasColumnName("nama_item");
            this.Property(t => t.mold_id).HasColumnName("mold_id");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.model).HasColumnName("model");
            this.Property(t => t.tooling_id).HasColumnName("tooling_id");
            this.Property(t => t.nama_mesin).HasColumnName("nama_mesin");
            this.Property(t => t.matrial).HasColumnName("matrial");
            this.Property(t => t.jenis_warna).HasColumnName("jenis_warna");
            this.Property(t => t.jumlah_produksi).HasColumnName("jumlah_produksi");
            this.Property(t => t.cavity).HasColumnName("cavity");
            this.Property(t => t.standard_cycle).HasColumnName("standard_cycle");
            this.Property(t => t.plan_down_time).HasColumnName("plan_down_time");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");




        }
    }
}
