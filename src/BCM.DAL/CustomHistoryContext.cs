using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.DAL
{
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Migrations.History;
    using BCM.Common;
    
    /// <summary>
    /// CustomHistoryContext class.
    /// </summary>
    public class CustomHistoryContext : HistoryContext
    {
        public CustomHistoryContext(DbConnection dbConnection, string defaultSchema)
            : base(dbConnection, defaultSchema)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().ToTable(tableName: Constants.TablePrefix + "MigrationHistory");
        }
    } 
}
