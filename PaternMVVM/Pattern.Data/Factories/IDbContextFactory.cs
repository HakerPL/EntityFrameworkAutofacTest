using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var dbConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Pattern;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            var context = new ApplicationDbContext(dbConnection);
            return context;

        }
    }
}
