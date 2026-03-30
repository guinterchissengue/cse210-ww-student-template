using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Each order belongs to one customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Adds products to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates total including shipping
    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        // Shipping depends on location
        if (_customer.LivesInUSA())
            total += 5;
        else
            total += 35;

        return total;
    }

    // Generates packing label (only product info)
    public string GetPackingLabel()
    {
        string result = "Packing Label:\n";

        foreach (Product p in _products)
        {
            result += p.GetPackingInfo() + "\n";
        }

        return result;
    }

    // Generates shipping label (customer + address)
    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingInfo();
    }
}