class ElectronicProduct : Product
{

    public ElectronicProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetDiscountedPrice()
    {
        return Price * 0.90m;
    }
}


