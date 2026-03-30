public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Stores full address details
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Checks if the address is in the USA (used for shipping cost)
    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Returns formatted address
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}