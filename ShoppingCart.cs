using System;
using System;

// Context class that applies a discount strategy
public class ShoppingCart
{
    private IDiscountStrategy discountStrategy;
    public decimal TotalAmount { get; private set; }

    // Constructor to initialize cart with total amount
    public ShoppingCart(decimal totalAmount)
    {
        TotalAmount = totalAmount;
        discountStrategy = new NoDiscount(); // Default strategy
    }

    // Method to set the discount strategy dynamically
    public void SetDiscountStrategy(IDiscountStrategy strategy)
    {
        discountStrategy = strategy;
    }

    // Method to calculate final price after applying discount
    public void Checkout()
    {
        decimal finalPrice = discountStrategy.ApplyDiscount(TotalAmount);
        Console.WriteLine($"Original Price: {TotalAmount:C}");
        Console.WriteLine($"Final Price after Discount: {finalPrice:C}");
    }
}

