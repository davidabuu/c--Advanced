using System.Data;
using Dapper;
using Helloworld.Models;
using Microsoft.Data.SqlClient;

namespace Helloworld // Note: actual namespace depends on the project name.
{

    internal class Program
    {
       public static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
            IDbConnection dbConnection = new SqlConnection(connectionString);
            string sqlCommand = "SELECT GETDATE()";
            DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
            Console.WriteLine(rightNow);
            Computer myComputer = new Computer()
            {
                Motherboard = "Z680",
                hasWifi = true,
                hasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 953.89m,
                videoCard = "rr55"
            };
            Console.WriteLine(myComputer.hasLTE);
        }
        
    }
}