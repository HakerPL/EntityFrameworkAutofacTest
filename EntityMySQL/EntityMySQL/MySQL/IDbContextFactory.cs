using MySql.Data.MySqlClient;

namespace EntityMySQL.MySQL
{
    public interface IDbContextFactory
    {
        ConnectDb CreateContext();
    }

    public class DbContextFactory : IDbContextFactory
    {
        public ConnectDb CreateContext()
        {
            //new SqlConnection("Server=127.0.0.1;Database=testapp;Uid=root;Pwd=root;"); //SqlConnection("Server=KAJETAN-ASUS\\SQLEXPRESS;Database=Pattern2;Trusted_Connection=True;")
            var dbConnection = new MySqlConnection("Server=127.0.0.1;Database=testapp;Uid=root;Pwd=root;");
            var context = new ConnectDb(dbConnection);
            return context;
        }
    }
}
