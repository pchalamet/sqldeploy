using System;
using System.Linq;
using System.Reflection;
using System.Data.SqlClient;

namespace SqlDeploy.Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            var deployer = new SqlProjectDeployer(args[0]);
            deployer.RecreateToAsync(new SqlConnection(args[1]), databaseName: args[2]);
        }
    }
}
