using System;using System;

class Program
{
    static void Main(string[] args)
    {
        // First order (USA customer)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alberto Mahanzul", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 20, 2));

        // Second order (international customer/Mozambique)
        Address address2 = new Address("Av 7 de Setembro", "Maxixe", "Inhambane", "Mozambique");
        Customer customer2 = new Customer("Guinter Chissengue", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P300", 500, 1));
        order2.AddProduct(new Product("Headphones", "P400", 50, 3));

        // Display first order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost().ToString("F2"));

        Console.WriteLine("\n----------------------\n");

        // Display second order
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost().ToString("F2"));
    }
}

