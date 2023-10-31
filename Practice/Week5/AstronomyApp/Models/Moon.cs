public class Moon : CelestialBody
{
    public Planet ParentPlanet { get; set; }

    public Moon(string name, double mass, double radius, Planet parentPlanet)
    : base(name, mass, radius)
    {
        ParentPlanet = parentPlanet;
    }

    public override void Describe()
    {
        System.Console.WriteLine($"{Name}\n{Mass}\n{Radius}\n{ParentPlanet.Name}");
    }
}