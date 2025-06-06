public class Product
{
    private string _name;
    private int _productID;
    private int _price;
    private int _productQuantity;

    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _productQuantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _productID;
    }

    public int GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _productQuantity;
    }

    public int TotalCost()
    {
        return _price * _productQuantity;
    }
}