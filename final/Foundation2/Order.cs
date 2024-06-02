public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public double ComputeTotalCost()
    {
        int shippingCost = 0;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        double total = shippingCost;
        foreach (Product product in _products)
        {
            total = total + product.TotalCost();
        }
        return total;
    }
    public string PackingLabel()
    {
        string label = $"{_customer.GetName()}\n";
        foreach (Product product in _products)
        {
            label = label + $"   {product.GetProductID()} - Quantity: {product.GetQuantity()}\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}