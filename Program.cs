





class Program
{
    static void Main()
    {
        Vehicle myCar = new Car();
        Vehicle myBike = new Bike();
        myCar.Start();
        myBike.Start();
        Console.ReadLine();
    }
}