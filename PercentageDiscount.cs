using System;
// Percentage-based discount strategy
public class PercentageDiscount : IDiscountStrategy
{
    private readonly decimal percentage;

    public PercentageDiscount(decimal percentage)
    {
        this.percentage = percentage;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * (percentage / 100));
    }
}

