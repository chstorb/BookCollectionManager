using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.DAL
{
    using System.Data.Entity.Infrastructure.Interception;
    using System.Data.Entity;
    using BCM.Diagnostics;
    using System.Data.Entity.SqlServer;

    /// <summary>
    /// CustomDbConfiguration class.
    /// </summary>
    public class CustomDbConfiguration : DbConfiguration
    {
        public CustomDbConfiguration()
        {
            SetHistoryContext("System.Data.SqlClient", (connection, defaultSchema) => new CustomHistoryContext(connection, defaultSchema));

            // Enable connection resiliency
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
#if DEBUG
            DbInterception.Add(new CustomDbCommandInterceptor());
            DbInterception.Add(new TransientErrorDbCommandInterceptor());
#endif
        }
    }
}
