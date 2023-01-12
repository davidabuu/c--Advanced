using System.Data;
using Dapper;
using Helloworld.Data;
using Helloworld.Models;
using Microsoft.Data.SqlClient;

namespace Helloworld // Note: actual namespace depends on the project name.
{

    internal class Program
    {
       public static void Main(string[] args)
        {
            DataContextDapper dapper = new DataContextDapper();
            string sqlCommand = "SELECT GETDATE()";
            DateTime rightNow = dapper.LoadDataSingle<DateTime>(sqlCommand);
            Computer myComputer = new Computer()
            {
                Motherboard = "Z680",
                hasWifi = true,
                hasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 953.89m,
                videoCard = "rr55"
            };
            string sql = @"INSERT INTO TutorialAppSchema.Computer (
                 Motherboard,
                hasWifi,
                hasLTE,
                ReleaseDate,
                Price,
                videoCard
            ) VALUES ('" + myComputer.Motherboard  + "',' " + myComputer.hasWifi
            + "',' " + myComputer.hasLTE
            + "',' " + myComputer.ReleaseDate
            + "',' " + myComputer.Price
            + "',' " + myComputer.videoCard
            + "')";
            Console.WriteLine(sql);
            bool result = dapper.ExecuteSql(sql);
            Console.WriteLine(result);
            Console.WriteLine(rightNow);
            string sqlSelect = @"SELECT  Motherboard,
                Computer.hasWifi,
                Computer.hasLTE,
                Computer.ReleaseDate,
                Computer.Price,
                Computer.videoCard FROM TutorialAppSchema.Computer";
                 IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);
                 foreach(Computer singleComputer in computers){
                    Console.WriteLine(myComputer.hasWifi);
                 }
        }
       
        
    }
}