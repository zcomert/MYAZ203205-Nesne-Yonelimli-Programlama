namespace ProductApp.Models
{
    public class Phone : Product
    {
        public String OS { get; set; }
        public double Size { get; set; }
        public Phone() : base()
        {
            System.Console.WriteLine("Phone default ctor has been called.");
        }

        public Phone(string name, decimal price) 
            : base(name, price)
        {
            
        }

        public void TakePhoto()
        {
            System.Console.WriteLine("Taking photo...");
        }

        public override void Sale()
        {
            System.Console.WriteLine($"{Name} - {Price} has been sold.");
            System.Console.WriteLine("An invoice has been created.");
        }
    }
}