public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, int speed, int doors) : base(brand, speed)
    {
        NumberOfDoors = doors;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Calls the base class method
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
}

