namespace OOP_Extra_Problems;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eco-Ride Urban Mobility System");

        // Creating a vehicle (UC-1)
        Vehicle vehicle = new Vehicle(
            vehicleId: "EV101",
            model: "EcoRide X1",
            batteryPercentage: 85
        );

        vehicle.DisplayDetails();

        Console.ReadLine();
    }
}
