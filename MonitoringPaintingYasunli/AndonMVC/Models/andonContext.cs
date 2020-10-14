using AndonMVC.Models.Mapping;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace AndonMVC.Models
{

    [DbConfigurationType(typeof(MultipleDbConfiguration))]
    public partial class andonContext : DbContext
    {

        static andonContext()
        {
            Database.SetInitializer<andonContext>(null);
        }

        public andonContext(string nameOrConnectionString)
            : base(MultipleDbConfiguration.GetMySqlConnection(nameOrConnectionString), true)
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 500;
        }

        public DbSet<callhistory> callhistories { get; set; }
        public DbSet<calluserlist> calluserlists { get; set; }
        public DbSet<historyreasonlist> historyreasonlists { get; set; }
        public DbSet<jobhistory> jobhistories { get; set; }
        public DbSet<mold> molds { get; set; }
        public DbSet<operatorx> operators { get; set; }
        public DbSet<operatorspphistory> operatorspphistories { get; set; }
        public DbSet<part> parts { get; set; }
        public DbSet<production> productions { get; set; }
        public DbSet<reasonlist> reasonlists { get; set; }
        public DbSet<spplist> spplists { get; set; }
        public DbSet<statuslist> statuslists { get; set; }
        public DbSet<part_on_mold> part_on_mold { get; set; }
        public DbSet<vjobhistory> vjobhistories { get; set; }
        public DbSet<vspplist> vspplists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new callhistoryMap());
            modelBuilder.Configurations.Add(new calluserlistMap());
            modelBuilder.Configurations.Add(new historyreasonlistMap());
            modelBuilder.Configurations.Add(new jobhistoryMap());
            modelBuilder.Configurations.Add(new moldMap());
            modelBuilder.Configurations.Add(new operatorMap());
            modelBuilder.Configurations.Add(new operatorspphistoryMap());
            modelBuilder.Configurations.Add(new partMap());
            modelBuilder.Configurations.Add(new productionMap());
            modelBuilder.Configurations.Add(new reasonlistMap());
            modelBuilder.Configurations.Add(new spplistMap());
            modelBuilder.Configurations.Add(new statuslistMap());
            modelBuilder.Configurations.Add(new part_on_moldMap());
            modelBuilder.Configurations.Add(new vjobhistoryMap());
            modelBuilder.Configurations.Add(new vspplistMap());
        }
    }
}
