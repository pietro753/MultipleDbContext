using System.Data.Entity;

namespace MsSqlLibrary
{
    //[DbConfigurationType(typeof(MsSqlConfiguration))]
    //[DbConfigurationType("MsSqlLibrary.MsSqlConfiguration, MsSqlLibrary")]
    public class MsSqlDbContext : DbContext
    {
        public MsSqlDbContext(string conntectionString)
            : base(conntectionString)
        {
        }

        public virtual IDbSet<Country> Countries { get; set; }
    }
}
