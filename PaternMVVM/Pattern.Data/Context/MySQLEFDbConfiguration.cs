using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MySql.Data.Entity;

namespace Pattern.Data.Context
{
    class MySqlEFDbConfiguration : DbConfiguration
    {
        public MySqlEFDbConfiguration()
        {
            SetExecutionStrategy(MySqlProviderInvariantName.ProviderName, () => new MySqlExecutionStrategy());
            //SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0"));
        }
    }
}
