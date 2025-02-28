using System;
// No discount strategy
public class NoDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount; // No discount applied
    }
}

