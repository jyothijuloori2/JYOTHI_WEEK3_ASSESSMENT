public class Bike : Vehicle
{
    public bool HasGear { get; set; }

    public Bike(string brand, int speed, bool hasGear) : base(brand, speed)
    {
        HasGear = hasGear;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo(); 
        Console.WriteLine($"Has Gear: {HasGear}");
    }
}

