using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Pattern.Entities;

namespace Pattern.Data
{

   

    public class ApplicationDbContext : DbContext
    {
        static System.Data.Common.DbConnection _dbConnection;

        public ApplicationDbContext()
        {
            ////Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>());
            //Database.Initialize(false);
        }

        public ApplicationDbContext(System.Data.Common.DbConnection dbConnection) : base(dbConnection, false) //: base("server=127.0.0.1;uid=root;pwd=kajko17W!;database=testdb2")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>());
            Database.Initialize(false);
            _dbConnection = dbConnection;
        }

        public class MyContextFactory : IDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext Create()
            {
                return new ApplicationDbContext(_dbConnection);
            }
        }


        public DbSet<Number> Numbers { get; set; }
    }
}