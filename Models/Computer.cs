namespace Helloworld.Models
{
    public class Computer
    {
        public string Motherboard { get; set; } = "";
        public int CPUcores { get; set; }
        public bool hasWifi { get; set; }
        public bool hasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string videoCard { get; set; } = "";
        // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
            // IDbConnection dbConnection = new SqlConnection(connectionString);
            // string sqlCommand = "SELECT GETDATE()";
            // DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
            // Console.WriteLine(rightNow);

    }
}