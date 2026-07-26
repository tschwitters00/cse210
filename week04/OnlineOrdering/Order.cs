public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total += product.GetTotalPrice();
        }

        if (_customer.IsUsa() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return Math.Round(total, 2);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
            packingLabel += $"{product.GetName()},{product.GetId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.GetDisplayText();
    }
}
