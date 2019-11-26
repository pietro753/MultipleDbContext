using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using MsSqlLibrary;
using Npgsql;
using NpgSqlLibrary;

namespace FunctionApp1
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            Database.SetInitializer<MsSqlDbContext>(null);
            Database.SetInitializer<NpgSqlDbContext>(null);

            var ctx = new MsSqlDbContext(@"your-cs-string");
            var countries = ctx.Countries.Take(10).ToList();

            var conn = NpgsqlFactory.Instance.CreateConnection();
            var connConnectionString = "your-cs-string";
            conn.ConnectionString = connConnectionString;

            var npgsqlctx = new NpgSqlDbContext(conn);
            var users = npgsqlctx.Users.Take(10).ToList();
        }
    }
}
