namespace ProductApp.Models
{
    public class Car : Product
    {
        public double NumberofWheels { get; set; }
        
        public String Color { get; set; }
        public void Drive () {
            System.Console.WriteLine("driving");
        }
        public void Stop()
        {
            System.Console.WriteLine("stoping");
        }

        public override void Sale()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i+1);
            }
            System.Console.WriteLine("Car has been sold.");
        }
    }
}