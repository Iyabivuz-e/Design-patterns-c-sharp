
namespace designPattern.OopPrinciples.Inheritance
{

    public class Vehicle
    {

        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }

        public void Starting()
        {
            System.Console.WriteLine("Starting...");
        }
        public void Stopping()
        {
            System.Console.WriteLine("Stopping...");
        }
    }
}