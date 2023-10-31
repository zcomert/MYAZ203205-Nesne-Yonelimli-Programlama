public abstract class SpaceShip
{
    public string Name { get; set; }
    public double Mass { get; set; }
    public double Fuel { get; set; }
    public int CrewCapacity { get; set; }
    public double Thrust { get; set; }
    public double SpecificImpulse { get; set; }

    public SpaceShip(string name, double mass, double fuel, int crewCapacity, double thrust, double specificImpulse)
    {
        Name = name;
        Mass = mass;
        Fuel = fuel;
        CrewCapacity = crewCapacity;
        Thrust = thrust;
        SpecificImpulse = specificImpulse;
    }

    public abstract void Launch();
    public abstract void Land();

    public void TravelTo(Planet planet)
    {
        var travelTime = 
        planet.Distance / CalculateTravelDistance(CalculateDeltaV(planet.Gravity));
        System.Console.WriteLine($"Travel Time to {planet.Name}: {travelTime}");
    }

    protected double CalculateDeltaV(double Gravity)
    {
        var deltaV = SpecificImpulse * Gravity * Math.Log((Mass + Fuel) / Mass);
        return deltaV;
    }

    protected double CalculateTravelDistance(double DeltaV)
    {
        var travelDistance = 2 * DeltaV / (Thrust * 1000);
        return travelDistance;
    }
}