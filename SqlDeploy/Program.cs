using System;
using System.Linq;
using System.Reflection;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SqlDeploy.Test
{
    class Program
    {
        public async static Task<int> Main(string[] args)
        {
            if (args.Length != 2) {
                Console.WriteLine("Usage: sqldeploy <projectFile> <connectionString> <dbName>");
                return 5;
            }

            var deployer = new SqlProjectDeployer(args[0]);
            await deployer.RecreateToAsync(new SqlConnection(args[1]), databaseName: args[2]);
            return 0;
        }
    }
}
