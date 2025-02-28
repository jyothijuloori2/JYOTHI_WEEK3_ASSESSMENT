using System;
using System.Runtime.ConstrainedExecution;

// Factory class
public class VehicleFactory
{
    public static Vehicle CreateVehicle(string type)
    {
        if (type.Equals("Car", StringComparison.OrdinalIgnoreCase))
        {
            return new Car();
        }
        else if (type.Equals("Bike", StringComparison.OrdinalIgnoreCase))
        {
            return new Bike();
        }
        else
        {
            throw new ArgumentException("Invalid vehicle type");
        }
    }
}

