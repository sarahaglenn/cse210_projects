public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public double ComputeTotalCost()
    {
        double subTotal = 0;
        int shipping;
        foreach (Product p in _products)
        {
            subTotal += p.ComputeTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return Math.Round(subTotal + shipping, 2);
    }
    public string GetPackingLabel()
    {
        string packingLabel = $"\nPACKING LABEL for {_customer.GetName()}:";
        foreach (Product p in _products)
        {
            // product name, quantity (I added because it's helpful to have on a packing label)
            packingLabel += $"\n{p.GetProductID()} {p.GetName()}, Quantity: {p.GetQuantity()}";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return "SHIPPING LABEL:\n" + _customer.GetName() + "\n" + _customer.GetAddressString();
    }
}