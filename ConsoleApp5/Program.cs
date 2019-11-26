using System.Data.Entity;
using System.Linq;
using MsSqlLibrary;
using NpgSqlLibrary;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<MsSqlDbContext>(null);
            Database.SetInitializer<NpgSqlDbContext>(null);

            var ctx = new MsSqlDbContext(@"name=MsSqlDbContext");
            var countries = ctx.Countries.Take(10).ToList();
           
            var npgsqlctx = new NpgSqlDbContext("name=NpgSqlDbContext");
            var users =  npgsqlctx.Users.Take(10).ToList();
        }
    }
}
