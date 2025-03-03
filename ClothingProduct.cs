class ClothingProduct : Product
{
    public ClothingProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetDiscountedPrice()
    {
        return Price * 0.80m;
    }
}

