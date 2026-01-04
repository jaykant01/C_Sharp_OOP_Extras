namespace OOP_Extra_Problems;

public abstract class Vehicle
{
    // Encapsulated properties
    public string VehicleId { get; private set; }
    public string Model { get; private set; }
    public int BatteryPercentage { get; private set; }

    // Constructor
    public Vehicle(string vehicleId, string model, int batteryPercentage)
    {
        VehicleId = vehicleId;
        Model = model;
        BatteryPercentage = batteryPercentage;
    }

    // Abstract method (contract)
    public abstract double CalculateTripCost(double distanceInKm);

    // Display vehicle details
    public void DisplayDetails()
    {
        Console.WriteLine("Vehicle Details:");
        Console.WriteLine($"ID: {VehicleId}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Battery: {BatteryPercentage}%");
    }
}
