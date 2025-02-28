using System;
// Fixed amount discount strategy
public class FixedAmountDiscount : IDiscountStrategy
{
    private readonly decimal discountAmount;

    public FixedAmountDiscount(decimal discountAmount)
    {
        this.discountAmount = discountAmount;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - discountAmount > 0 ? totalAmount - discountAmount : 0;
    }
}

