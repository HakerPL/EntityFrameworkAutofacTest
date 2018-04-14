using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Pattern.Data.Context;
using Pattern.Entities;

namespace Pattern.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ApplicationDbContext : DbContext
    {
        static System.Data.Common.DbConnection _dbConnection;

        //public ApplicationDbContext()
        //{
        //    //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>());
        //    Database.Initialize(false);
        //}

        public ApplicationDbContext(System.Data.Common.DbConnection dbConnection) : base(dbConnection, false) //base("Server=127.0.0.1;Database=testapp;Uid=root;Pwd=root;") //
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