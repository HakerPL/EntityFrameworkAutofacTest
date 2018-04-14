using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EntityMySQL.Migrations;
using MySql.Data.MySqlClient;

namespace EntityMySQL.MySQL
{
    public class ConnectDb : DbContext
    {
        private static System.Data.Common.DbConnection _dbConnection { get; set; }

        public ConnectDb(System.Data.Common.DbConnection dbConnection) : base(dbConnection, false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ConnectDb, Configuration>());
            Database.Initialize(false);
            _dbConnection = dbConnection;
        }

        public ConnectDb() : base (new MySqlConnection("Server=127.0.0.1;Database=testapp;Uid=root;Pwd=root;") , false)
        {
            Database.Initialize(false);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ConnectDb, DataContextConfiguration>());
        }


        public class MyContextFactory : IDbContextFactory<ConnectDb>
        {
            public ConnectDb Create()
            {
                return new ConnectDb(_dbConnection);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Number> Numbers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
    }
}
