namespace OOP_Extra_Problems;

public class ElectricCar
{
    public int SeatingCapacity { get; private set; }

    // Constructor calls parent constructor
    public ElectricCar(string vehicleId, string model, int batteryPercentage, int seatingCapacity)
        : base(vehicleId, model, batteryPercentage)
    {
        SeatingCapacity = seatingCapacity;
    }

    public void DisplayCarDetails()
    {
        DisplayDetails();
        Console.WriteLine($"Seating Capacity: {SeatingCapacity}");
    }

    public override double CalculateTripCost(double distanceInKm)
    {
        return distanceInKm * 15;
    }
}

public class ElectricScooter : Vehicle
{
    public int MaxSpeedLimit { get; private set; }

    // Constructor calls parent constructor
    public ElectricScooter(string vehicleId, string model, int batteryPercentage, int maxSpeedLimit)
        : base(vehicleId, model, batteryPercentage)
    {
        MaxSpeedLimit = maxSpeedLimit;
    }

    public void DisplayScooterDetails()
    {
        DisplayDetails();
        Console.WriteLine($"Max Speed Limit: {MaxSpeedLimit} km/h");
    }

    public override double CalculateTripCost(double distanceInKm)
    {
        return distanceInKm * 7; 
    }
}
