using System;public class Customer
{
    private string _name;
    private Address _address;

    // Combines customer name with their address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Uses Address class to determine if customer is in USA
    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    // Returns full shipping label info
    public string GetShippingInfo()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}

