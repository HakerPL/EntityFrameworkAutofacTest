using MySql.Data.MySqlClient;

namespace Pattern.Data.Factories
{
    public interface IDbContextFactory
    {
        ApplicationDbContext CreateContext();
    }

    public class DbContextFactory : IDbContextFactory
    {
        public ApplicationDbContext CreateContext()
        {
            var dbConnection = new MySqlConnection("Server=127.0.0.1;Database=testapp;Uid=root;Pwd=root;");//new SqlConnection("Server=127.0.0.1;Database=testapp;Uid=root;Pwd=root;"); //SqlConnection("Server=KAJETAN-ASUS\\SQLEXPRESS;Database=Pattern2;Trusted_Connection=True;")
            var context = new ApplicationDbContext(dbConnection);
            return context;

        }
    }
}
