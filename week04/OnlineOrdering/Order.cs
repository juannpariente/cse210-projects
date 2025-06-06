public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public int TotalPrice()
    {
        int totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.TotalCost();
        }
        if (_customer.LivesInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }

    public string PackingLabel()
    {
        List<string> lines = new List<string>();
        foreach (Product product in _products)
        {
            lines.Add($"{product.GetName()} - {product.GetID}");
        }
        return string.Join("\n", lines);
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    public void AddProdcut(Product product)
    {
        _products.Add(product);
    }
}