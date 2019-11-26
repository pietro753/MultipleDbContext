using System.Data.Common;
using System.Data.Entity;

namespace NpgSqlLibrary
{
    //[DbConfigurationType(typeof(NpgSqlConfiguration))]
    //[DbConfigurationType("NpgSqlLibrary.NpgSqlConfiguration, NpgSqlLibrary")]
    public class NpgSqlDbContext : DbContext
    {
        public NpgSqlDbContext(string conntectionString)
            : base(conntectionString)
        {
        }

        public NpgSqlDbContext(DbConnection connection)
        : base(connection, true)
        {

        }

        public virtual DbSet<User> Users { get; set; }
    }
}
