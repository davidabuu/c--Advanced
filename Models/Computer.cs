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

    }
}