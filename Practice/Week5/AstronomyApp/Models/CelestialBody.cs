public abstract class CelestialBody
{
    public string Name { get; set; }
    public double Mass { get; set; }
    public double Radius { get; set; }

    public CelestialBody(string name, double mass, double radius)
    {
        Name = name;
        Mass = mass;
        Radius = radius;
    }

    public abstract void Describe();
}