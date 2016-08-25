using System.Data.Entity;
using autoProject.dbClases;

namespace autoProject
{
    class OurBaseContext : DbContext
    { 
        public OurBaseContext() : base ("DbConnection")
        {
           // Database.SetInitializer(new DbDefoultInitializer());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OurBaseContext>());
            //Database.Initialize(true);
        }

       
        public DbSet<Brend> Brends { get; set; }

        public  DbSet<Car> Cars { get; set; }

        public DbSet<Client>Clients  { get; set; }

        public DbSet<DetailToPerform> DetailToPerforms  { get; set; }

        public DbSet<Emploee> Emploees  { get; set; }

        public DbSet<Model> Models  { get; set; }

        public DbSet<Order>Orders  { get; set; }

        public DbSet<PriseSpeaPart> PriseSpeaParts  { get; set; }

        public DbSet<SelaryWorker> SelaryWorkers  { get; set; }

        public DbSet<SpeaPart> SpeaParts  { get; set; }

        public DbSet<TypeOfWork> TypeOfWorks  { get; set; }

        public DbSet<User> Users  { get; set; }
        }
}
