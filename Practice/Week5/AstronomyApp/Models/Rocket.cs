public class Rocket : SpaceShip
{
    public Rocket(string name, double mass, double fuel, int crewCapacity, double thrust, double specificImpulse) 
    : base(name, mass, fuel, crewCapacity, thrust, specificImpulse)
    {
    }

    public override void Land()
    {
        System.Console.WriteLine($"{Name} Rocket is Landed!");
    }

    public override void Launch()
    {
        System.Console.WriteLine($"{Name} Rocket is Launched!");
    }

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