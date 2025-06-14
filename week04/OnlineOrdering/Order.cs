using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;

        decimal shippingCost;

        if (_customer.LiveInUSA())
        {
            shippingCost = 5.00m;
        }
        else
        {
            shippingCost = 35.00m;
        }

        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        return totalPrice + shippingCost;
    }

    public String DisplayPackingLabel()
    {
        String packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public String DisplayShippingLabel()
    {
        String shippingLabel = "Shipping Label:\n";

        shippingLabel += $"Customer: {_customer.GetName()}\n";
        shippingLabel += $"Address: {_customer.GetAddress().GetFullAddress()}\n";

        return shippingLabel;
    }
}