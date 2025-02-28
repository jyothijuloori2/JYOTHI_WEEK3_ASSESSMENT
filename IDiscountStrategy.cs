using System;
// Interface for discount strategies
public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

