public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    //  Product data
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //   Price and quantity
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Returns product info for packing label
    public string GetPackingInfo()
    {
        return $"{_name} (ID: {_productId}) x{_quantity}";
    }
}