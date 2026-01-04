namespace OOP_Extra_Problems;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eco-Ride Urban Mobility System");

        // Mixed vehicle list (polymorphism)
        List<Vehicle> fleet = new List<Vehicle>
            {
                new ElectricCar("CAR101", "EcoCar Pro", 80, 5),
                new ElectricScooter("SCOOT201", "EcoScoot Lite", 65, 45)
            };

        Console.WriteLine("\nProcessing Rentals...\n");

        foreach (Vehicle vehicle in fleet)
        {
            double cost = vehicle.CalculateTripCost(10);
            Console.WriteLine($"{vehicle.GetType().Name} Trip Cost: ${cost}");
        }

        Console.ReadKey();
    }
}
