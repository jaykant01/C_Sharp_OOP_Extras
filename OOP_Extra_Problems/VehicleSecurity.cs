namespace OOP_Extra_Problems;

public class VehicleSecurity
{
    // Private attributes (secured data)
    private string _maintenanceStatus;
    private double _rentalPrice;
    private int _batteryPercentage;

    // Constructor
    public VehicleSecurity(string maintenanceStatus, double rentalPrice, int batteryPercentage)
    {
        MaintenanceStatus = maintenanceStatus;
        RentalPrice = rentalPrice;
        BatteryPercentage = batteryPercentage;
    }

    // Getter & Setter for Maintenance Status
    public string MaintenanceStatus
    {
        get { return _maintenanceStatus; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Maintenance status cannot be empty.");
            }
            _maintenanceStatus = value;
        }
    }

    // Getter & Setter for Rental Price
    public double RentalPrice
    {
        get { return _rentalPrice; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Rental price cannot be negative.");
            }
            _rentalPrice = value;
        }
    }

    // Getter & Setter with validation logic
    public int BatteryPercentage
    {
        get { return _batteryPercentage; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Battery percentage must be between 0 and 100.");
            }
            _batteryPercentage = value;
        }
    }
}
