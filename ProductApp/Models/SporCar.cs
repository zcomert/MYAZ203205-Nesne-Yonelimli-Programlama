namespace ProductApp.Models;

public class SporCar : Car
{
    public void OpenTurbo()
    {
        System.Console.WriteLine("Turbo has been opened.");
    }

    public override void Sale()
    {
        base.Sale();
        for (int i = 10; i >= 0 ; i--)
        {
            System.Console.WriteLine(i);
        }
        System.Console.WriteLine("SporCar has been sold.");
    }
}