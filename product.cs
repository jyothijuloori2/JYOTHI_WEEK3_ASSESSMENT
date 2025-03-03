class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual decimal GetDiscountedPrice()
    {
       
        return Price * 0.95m;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} - Original Price: ${Price}, Discounted Price: ${GetDiscountedPrice()}");
    }
}

