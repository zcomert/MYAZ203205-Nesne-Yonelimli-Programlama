public class Planet : CelestialBody
{
    public double Distance { get; set; }
    public double Gravity { get; set; }


    public Planet(string name, double mass, double radius, double distance, double gravity) 
    : base(name, mass, radius)
    {
        Gravity = gravity;
        Distance = distance;
    }

    public override void Describe()
    {
        System.Console.WriteLine($"{Name}\n{Mass}\n{Radius}\n{Distance}\n{Gravity}");
    }
}